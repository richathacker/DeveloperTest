using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreDemo.Data.Repository
{
    public interface IRepository<T>
    {
        T GetById<TKey>(TKey id);

        IQueryable<T> GetAll();

        void Insert(T entity);

        void Update(T entity);

        void Delete(object key);
    }
}
