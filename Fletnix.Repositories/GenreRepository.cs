using Fletnix.Model;
using System;
using System.Collections.Generic;
using System.Text;

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
            throw new NotImplementedException();
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
