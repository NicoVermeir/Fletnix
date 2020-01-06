﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Fletnix.Model;

namespace Fletnix.Services
{
    public interface ICatalogService
    {
        Task<IList<CatalogItem>> GetMovies();
        void SaveCatalogItem(CatalogItem item);

        void UpdateCatalogItem(CatalogItem item);
    }
}
