using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DipensBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);

        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedEnumerable<T>> orderBy = null,
            string includeProperties = null
            );
        T GetFristOrDefault(
            Expression<Func<T, bool>> fillter = null,
            string includeProperties = null
            );
        void Add(T entity);  //to add an entity

        void Remove(int id); // to remove an object or category

        void RemoveRange(IEnumerable<T> entity);  // removes a complete range of entities
    }
}
