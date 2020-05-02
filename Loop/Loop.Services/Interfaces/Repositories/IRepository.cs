using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Loop.Services.Repositories_interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int? id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        void Insert(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity); 
    }
}
