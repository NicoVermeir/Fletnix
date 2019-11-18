using System.Collections.Generic;
using Fletnix.Model;

namespace Fletnix.Services
{
    public interface ICatalogService
    {
        IList<CatalogItem> GetMovies();
        void SaveCatalogItem(CatalogItem item);
    }
}
