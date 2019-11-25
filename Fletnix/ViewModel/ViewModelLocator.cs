using Autofac;
using Fletnix.Services.Infrastructure;

namespace Fletnix.ViewModel
{
    public class ViewModelLocator
    {
        private readonly IContainer _container;

        public ViewModelLocator()
        {
            //autofac
            var builder = new ContainerBuilder();
            builder.RegisterModule<ServicesModule>();
            
            builder.RegisterType<MainViewModel>().SingleInstance();
            builder.RegisterType<CreateCatalogItemViewModel>().SingleInstance();
            builder.RegisterType<CreateGenreViewModel>().SingleInstance();
            builder.RegisterType<CatalogItemDetailViewModel>().SingleInstance();

            _container = builder.Build();
            _container.Resolve<CatalogItemDetailViewModel>();

            // Inversion Of Control pattern
            // Dependency Injection
            //SimpleIoc.Default.Register<ICatalogService, CatalogService>();
            //SimpleIoc.Default.Register<MainViewModel>();
            //SimpleIoc.Default.Register<CreateCatalogItemViewModel>();
            //SimpleIoc.Default.Register<CatalogItemDetailViewModel>(true);
        }

        public MainViewModel Main => _container.Resolve<MainViewModel>();
        public CreateCatalogItemViewModel CreateCatalogItem => _container.Resolve<CreateCatalogItemViewModel>();
        public CreateGenreViewModel CreateGenre => _container.Resolve<CreateGenreViewModel>();
        public CatalogItemDetailViewModel CatalogItemDetail => _container.Resolve<CatalogItemDetailViewModel>();
    }
}
