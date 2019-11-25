using System;
using System.Collections.Generic;
using System.Text;
using Fletnix.Messages;
using Fletnix.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Fletnix.Services;


namespace Fletnix.ViewModel
{
    public class CatalogItemDetailViewModel : ViewModelBase
    {
        // Fields
        private int? _numberOfLikes;
        private int? _numberOfDislikes;
        private readonly ICatalogService _catalogService;
        private CatalogItem _catalogItem;

        // Properties
        public int? NumberOfLikes
        {
            get => _numberOfLikes;
            set
            {
                _numberOfLikes = value;
                CatalogItem.AmountOfLikes = _numberOfLikes;
                RaisePropertyChanged();
            }
        }
        public int? NumberOfDislikes
        {
            get => _numberOfDislikes;
            set
            {
                _numberOfDislikes = value;
                CatalogItem.AmountOfDislikes = _numberOfDislikes;
                RaisePropertyChanged();
            }
        }

        private RelayCommand _addLikeCommand { get; set; }
        private RelayCommand _addDisLikeCommand { get; set; }

        public CatalogItem CatalogItem
        {
            get => _catalogItem;
            set
            {
                _catalogItem = value;
            }
        }

        // Constructor for view model

        public CatalogItemDetailViewModel(ICatalogService catalogService)
        {
            _catalogService = catalogService;
            MessengerInstance.Register<CatalogItemDetailsMessage>(this, OnCatalogItemReceived);
        }

        //Receive message 
        private void OnCatalogItemReceived(CatalogItemDetailsMessage message)
        {
            CatalogItem = message.CatalogItem;
            NumberOfLikes = CatalogItem.AmountOfLikes;
            NumberOfDislikes = CatalogItem.AmountOfDislikes;
        }

        // Command to add a new like 

        public RelayCommand AddLikeCommand =>
            _addLikeCommand ??= new RelayCommand(AddLike);

        private void AddLike()
        {
            NumberOfLikes++;
            _catalogService.UpdateCatalogItem(CatalogItem);
        }

        // Command to add a new dislike

        public RelayCommand AddDislikeCommand =>
            _addDisLikeCommand ??= new RelayCommand(AddDislike);

        private void AddDislike()
        {
            NumberOfDislikes++;
            _catalogService.UpdateCatalogItem(CatalogItem);
        }
    }
}
