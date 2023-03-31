﻿using System.Linq.Expressions;

namespace ArsenalFanPage.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T GetFirstOrDefault(Expression<Func<T, bool>> filter);
		T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null);
		IEnumerable<T> GetAll();
		void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
