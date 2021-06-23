using CharityProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RestaurantDeliveryOnline.Application.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        void SaveChanges();

        IList<T> GetAll();
        List<T> GetWith(Expression<Func<T, bool>> where);
        List<T> GetWith(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includes);
        List<T> GetPage(int pageIndex, int pageSize, params Expression<Func<T, object>>[] includes);
        int Count();
        //========crud=========//
        T Add(T item);
        void AddRange(List<T> range);
        T Update(T item);
        void Remove(T entity);

        T Single(Expression<Func<T, bool>> where);
        T Single(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includes);
        bool Any(Expression<Func<T, bool>> where);
        bool Any();
        IQueryable<T> Where(Expression<Func<T, bool>> where);

    }
}
