using Fletnix.Messages;
using Fletnix.Model;
using Fletnix.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fletnix.ViewModel
{
    public class CreateGenreViewModel : ViewModelBase
    {
        private readonly IGenreService _genreService;

        private RelayCommand _addGenreCommand;
        private string _name;

        public Genre NewGenre { get; set; }

        public RelayCommand AddGenreCommand => _addGenreCommand ??= new RelayCommand(AddGenre);

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public CreateGenreViewModel(IGenreService genreService)
        {
            _genreService = genreService;
            NewGenre = new Genre();

        }

        private void AddGenre()
        {
            NewGenre.Name = Name;

            _genreService.SaveGenre(NewGenre);

            MessengerInstance.Send(new GenreCreatedMessage(NewGenre));
            NewGenre = new Genre();
        }
    }
}
