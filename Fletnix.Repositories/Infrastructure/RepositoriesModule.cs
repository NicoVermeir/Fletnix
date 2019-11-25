using Autofac;

namespace Fletnix.Repositories.Infrastructure
{
    public class RepositoriesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CatalogItemRepository>().AsImplementedInterfaces();
            builder.RegisterType<GenreRepository>().AsImplementedInterfaces();
        }
    }
}
