﻿using ArsenalFanPage.Data;
using ArsenalFanPage.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ArsenalFanPage.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
			_db.DetailsMatch.Include(u => u.Match);
			this.dbSet = _db.Set<T>();
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }
		//public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null)
		//{
		//	IQueryable<T> query = dbSet;
		//	if (filter != null)
		//	{
		//		query = query.Where(filter);
		//	}
		//	if (includeProperties != null)
		//	{
		//		foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
		//		{
		//			query = query.Include(includeProp);
		//		}
		//	}
		//	return query.ToList();

		//}

		public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }
		public T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null)
		{
			IQueryable<T> query = dbSet;
			query = query.Where(filter);
			//if (includeProperties != null)
			//{
				query = query.Include(includeProperties);
			//}
			return query.FirstOrDefault();
		}

		public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
    }
}
