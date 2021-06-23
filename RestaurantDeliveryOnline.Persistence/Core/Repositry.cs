using CharityProject.Domain.Common;
using Microsoft.EntityFrameworkCore;
using RestaurantDeliveryOnline.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RestaurantDeliveryOnline.Persistance.Core
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private DbSet<T> _store = null;

        public DbContext dbContext => provider.GetService(typeof(IDatabaseService)) as DbContext;
        protected DbSet<T> store => _store ?? dbContext.Set<T>();

        private IServiceProvider provider;

        public Repository(IServiceProvider provider)
        {
            this.provider = provider;
        }

        public virtual T Add(T item)
        {
            dbContext.Entry(item).State = EntityState.Added;
            return store.Add(item).Entity;
        }

        public IList<T> GetAll()
        {
            var res = store.ToList();
            return res;
        }

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        public T Update(T item)
        {
            store.Attach(item);
            dbContext.Entry(item).State = EntityState.Modified;
            return item;
        }

        public virtual T Single(Expression<Func<T, bool>> where)
        {
            var result = store.FirstOrDefault(where);
            return result;
        }

        public virtual bool Any(Expression<Func<T, bool>> where)
        {
            bool res = store.Any(where);
            return res;
        }
        public virtual bool Any()
        {
            return store.Any();
        }
        public void Remove(T entity)
        {
            if (entity != null)
            {
                store.Remove(entity);
                dbContext.Entry(entity).State = EntityState.Deleted;
            }
        }

       

        public virtual List<T> GetWith(Expression<Func<T, bool>> where)
        {
            var result = store.Where(where).ToList();

            return result;
        }
        public virtual List<T> GetWith(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includes)
        {
            var query = store.AsQueryable();
            foreach (var include in includes)
                query = query.Include(include);

            return query.Where(where).ToList();

        }

        public virtual IQueryable<T> Where(Expression<Func<T, bool>> where)
        {
            var query = store.AsQueryable();

            return query.Where(where);
        }

        public List<T> GetPage(int pageIndex, int pageSize, params Expression<Func<T, object>>[] includes)
        {
            var query = store.AsQueryable();
            int skipCount = (pageIndex - 1) * pageSize;

            foreach (var include in includes)
                query = query.Include(include);

            return query.Skip(skipCount).Take(pageSize).ToList();
        }

        public virtual int Count()
        {
            return this.store.Count();
        }

        public virtual void AddRange(List<T> range)
        {
            range.ForEach(obj =>
            {
                Add(obj);
            });
        }

        public T Single(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includes)
        {
            var query = store.AsQueryable();
            foreach (var include in includes)
                query = query.Include(include);

            var result = query.FirstOrDefault(where);
            return result;
        }
    }

}
