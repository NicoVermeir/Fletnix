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
        private readonly ICatalogService _catalogService; 
        public CatalogItem CatalogItem { get; set; } // raise property changed nog in setter
        private RelayCommand _addLikeCommand { get; set; }

        public CatalogItemDetailViewModel(ICatalogService catalogService)
        {
            _catalogService = catalogService;
            MessengerInstance.Register<CatalogItemDetailsMessage>(this, OnCatalogItemReceived);
        }

        private void OnCatalogItemReceived(CatalogItemDetailsMessage message)
        {
            CatalogItem = message.CatalogItem;
        }

        public RelayCommand AddLikeCommand => 
            _addLikeCommand ??= new RelayCommand(AddLike);

        private void AddLike()
        {
            CatalogItem.AmountOfLikes++;
            _catalogService.UpdateCatalogItem(CatalogItem);
            RaisePropertyChanged();
            
        }
    }
}
