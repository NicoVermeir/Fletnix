using System;
using System.Collections.Generic;
using System.Linq;
using Fletnix.Model;
using Microsoft.EntityFrameworkCore;

namespace Fletnix.Api.Repositories
{
    public class CatalogItemRepository : IRepository<CatalogItem>
    {
        public bool Create(CatalogItem item)
        {
            try
            {
                var context = new FletnixContext();
                context.CatalogItems.Add(item);
                context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public IList<CatalogItem> Get()
        {
            var context = new FletnixContext();
            return context.CatalogItems.ToList();
        }

        public CatalogItem GetById(int id)
        {
            var context = new FletnixContext();
            return context.CatalogItems.Find(id);
        }

        public CatalogItem GetByName(string name)
        {
            var context = new FletnixContext();
            return context.CatalogItems.FirstOrDefault(_ => _.Title == name);
        }

        public bool Update(CatalogItem item)
        {
            var context = new FletnixContext();
            context.Attach(item);
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();

            return true;
        }

        public bool Delete(CatalogItem item)
        {
            var context = new FletnixContext();
            context.CatalogItems.Remove(item);
            context.SaveChanges();

            return true;
        }
    }
}
