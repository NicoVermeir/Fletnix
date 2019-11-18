using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Fletnix.Messages;
using Fletnix.Model;
using Fletnix.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Fletnix.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        //readonly: kan enkel geinstantieerd worden vanuit constructor
        private readonly ICatalogService _catalogService;
        private CatalogItem _selectedCatalogItem;
        
        public CatalogItem SelectedCatalogItem
        {
            get => _selectedCatalogItem;
            set
            {
                _selectedCatalogItem = value;
                MessengerInstance.Send(new CatalogItemDetailsMessage(_selectedCatalogItem));
            }
        }

        public ObservableCollection<CatalogItem> Catalog { get; set; }

        

        // field krijgt pas instantie als property voor de eerste keer aangeroepen word
        //public ICommand CounterClickCommand =>
        //    _counterClickCommand ?? (_counterClickCommand = new RelayCommand(CounterClicked));

        // bijna hetzelfde als

        //public ICommand CounterClickCommand { get; set; }
        //public MainViewModel()
        //{
        //    CounterClickCommand = new RelayCommand(CounterClicked);
        //}


        //public string Foo => "Hello world";

        // zelfde als

        //public string Foo
        //{
        //    get { return "Hello world"; }
        //}


        public MainViewModel(ICatalogService catalogService)
        {
            _catalogService = catalogService;

            IList<CatalogItem> catalog = _catalogService.GetMovies();
            //Catalog = _catalogService.GetMovies().ToList();
            Catalog = new ObservableCollection<CatalogItem>(catalog);

            MessengerInstance.Register<CatalogItemCreatedMessage>(this, OnCatalogItemCreated);
        }

        private void OnCatalogItemCreated(CatalogItemCreatedMessage message)
        {
            Catalog.Add(message.NewCatalogItem);
        }

        //private void CounterClicked()
        //{
        //    Counter++;

        //    Catalog.Add($"Film {Catalog.Count}");

        //    var vm = SimpleIoc.Default.GetInstance<MainViewModel>();
        //}
    }
}
