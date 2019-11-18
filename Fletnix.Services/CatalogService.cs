using System.Collections.Generic;
using Fletnix.Model;
using Fletnix.Repositories;

namespace Fletnix.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly IRepository<CatalogItem> _catalogRepository;

        public CatalogService(IRepository<CatalogItem> catalogRepository)
        {
            _catalogRepository = catalogRepository;
        }

        public IList<CatalogItem> GetMovies()
        {
            return _catalogRepository.Get();
        }

        public void SaveCatalogItem(CatalogItem item)
        {
            _catalogRepository.Create(item);
        }

        public void UpdateCatalogItem(CatalogItem item)
        {
            _catalogRepository.Update(item);
        }
    }
}
