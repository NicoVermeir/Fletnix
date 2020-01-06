using System.Collections.Generic;

namespace Fletnix.Api.Repositories
{
    public interface IRepository<T>
    {
        bool Create(T item);

        IList<T> Get();

        T GetById(int id);

        bool Update(T item);

        bool Delete(T item);
    }
}
