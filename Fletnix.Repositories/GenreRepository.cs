using Fletnix.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Fletnix.Repositories
{
    class GenreRepository : IRepository<Genre>
    {
        public bool Create(Genre item)
        {
            try
            {
                var context = new FletnixContext();
                context.Genre.Add(item);
                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Genre item)
        {
            throw new NotImplementedException();
        }

        public IList<Genre> Get()
        {
            var context = new FletnixContext();
            return context.Genre.ToList();
        }

        public Genre GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Genre item)
        {
            throw new NotImplementedException();
        }
    }
}
