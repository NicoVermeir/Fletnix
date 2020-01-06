﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fletnix.Repositories
{
    public interface IRepository<T>
    {
        bool Create(T item);

        Task<IList<T>> Get();

        T GetById(int id);

        bool Update(T item);

        bool Delete(T item);
    }
}
