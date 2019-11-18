using System;
using System.Collections.Generic;
using System.Text;
using Fletnix.Messages;
using Fletnix.Model;
using GalaSoft.MvvmLight;

namespace Fletnix.ViewModel
{
    public class CatalogItemDetailViewModel : ViewModelBase
    {
        public CatalogItem CatalogItem { get; set; }

        public CatalogItemDetailViewModel()
        {
            MessengerInstance.Register<CatalogItemDetailsMessage>(this, OnCatalogItemReceived);
        }

        private void OnCatalogItemReceived(CatalogItemDetailsMessage message)
        {
            CatalogItem = message.CatalogItem;
        }
    }
}
