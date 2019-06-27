using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SIGSUC.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {

        Task<TEntity> GetAsync(int? id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
    }
}
