using Fletnix.Messages;
using Fletnix.Model;
using Fletnix.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Fletnix.ViewModel
{
    public class CreateCatalogItemViewModel : ViewModelBase
    {
        private readonly ICatalogService _catalogService;

        private RelayCommand _addCatalogItemCommand;
        private string _title;

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

        public CreateCatalogItemViewModel(ICatalogService catalogService)
        {
            _catalogService = catalogService;
            NewCatalogItem = new CatalogItem();
        }

        private void AddCatalogItem()
        {
            NewCatalogItem.Title = Title;

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
