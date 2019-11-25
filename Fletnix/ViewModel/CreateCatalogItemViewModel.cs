using Fletnix.Messages;
using Fletnix.Model;
using Fletnix.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Fletnix.ViewModel
{
    public class CreateCatalogItemViewModel : ViewModelBase
    {
        private readonly ICatalogService _catalogService;
        private Genre _genre;
        private RelayCommand _addCatalogItemCommand;
        private readonly IGenreService _genreService;
        private string _title;

        public ObservableCollection<Genre> Genres { get; set; }

        public CatalogItem NewCatalogItem { get; set; }

        public RelayCommand AddCatalogItemCommand =>
            _addCatalogItemCommand ??= new RelayCommand(AddCatalogItem, CheckCanExecute); // C# 8 feature: compound assigments

        public string Title
        {
            get => _title;
            set
            {
                _title = value; 
                AddCatalogItemCommand.RaiseCanExecuteChanged();
            }
        }

        public CreateCatalogItemViewModel(ICatalogService catalogService, IGenreService genreService)
        {
            _catalogService = catalogService;
            _genreService = genreService;
            NewCatalogItem = new CatalogItem();

            IList<Genre> genres = _genreService.GetGenres();

            Genres = new ObservableCollection<Genre>(genres);
        }
        public Genre genre
        {
            get => _genre;
            set
            {
                _genre = value;
            }
        }

        private void AddCatalogItem()
        {
            NewCatalogItem.Title = Title;
            NewCatalogItem.GenreId = NewCatalogItem.Genre.Id;
            NewCatalogItem.Genre = null;

            _catalogService.SaveCatalogItem(NewCatalogItem);

            MessengerInstance.Send(new CatalogItemCreatedMessage(NewCatalogItem));
            NewCatalogItem = new CatalogItem();
        }

        private bool CheckCanExecute()
        {
            return !string.IsNullOrWhiteSpace(Title);
        }
    }
}
