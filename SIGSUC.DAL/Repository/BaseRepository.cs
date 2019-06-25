using Microsoft.EntityFrameworkCore;
using SIGSUC.DAL.Context;
using SIGSUC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SIGSUC.DAL.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly SIGSUCContext SICSUCContext;
        internal DbSet<TEntity> _dbSet;

        public BaseRepository(SIGSUCContext sicsucContexto)
        {
            SICSUCContext = sicsucContexto;
            _dbSet = SICSUCContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {

            _dbSet.Add(entity);
            SICSUCContext.SaveChanges();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _dbSet.AddRange(entities);
            SICSUCContext.SaveChanges();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public TEntity Get(int? id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
            SICSUCContext.SaveChanges();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
            SICSUCContext.SaveChanges();
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.SingleOrDefault(predicate);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            SICSUCContext.Entry(entity).State = EntityState.Modified;
            SICSUCContext.SaveChanges();
        }
    }
}
