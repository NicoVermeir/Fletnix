using System.Linq;
using Autofac;
using Fletnix.Repositories.Infrastructure;

namespace Fletnix.Services.Infrastructure
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<RepositoriesModule>();

            // registreer alle services als hun interfaces
            // gebruikt reflection
            builder.RegisterTypes(typeof(ServicesModule).Assembly.GetTypes()
                    .Where(_ => _.Name.EndsWith("Service") && _.IsClass)
                    .ToArray())
                    .AsImplementedInterfaces();

            //builder.RegisterType<CatalogService>().AsImplementedInterfaces();
        }
    }
}
