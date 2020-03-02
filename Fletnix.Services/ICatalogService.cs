using System.Collections.Generic;
using Fletnix.Model;

namespace Fletnix.Services
{
    public interface ICatalogService
    {
        IList<CatalogItem> GetMovies();
        CatalogItem GetById(int id);
        void SaveCatalogItem(CatalogItem item);

        void UpdateCatalogItem(CatalogItem item);
    }
}
