using FL.Data.Context;
using FL.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FL.Data.Repositories
{
	public abstract class RepositoryBase<T> : IRepositoryBase<T>
		where T : class
	{
		private readonly ApplicationDbContext _dbcontext;

		protected DbSet<T> DbSet { get; }

		public RepositoryBase(ApplicationDbContext context)
		{
			_dbcontext = context;
			DbSet = _dbcontext.Set<T>();
		}

		public virtual Task<List<T>> GetAsync(
			Expression<Func<T, bool>> whereExpr = null,
			Expression<Func<IQueryable<T>, IIncludableQueryable<T, object>>> includeExpr = null,
			Expression<Func<IQueryable<T>, IOrderedQueryable<T>>> orderExpr = null)
		{
			var queryable = DbSet.AsQueryable();

			if (whereExpr != null)
			{
				queryable = queryable.Where(whereExpr);
			}

			if (includeExpr != null)
			{
				queryable = includeExpr.Compile().Invoke(queryable);
			}

			if (orderExpr != null)
			{
				queryable = orderExpr.Compile().Invoke(queryable);
			}

			return queryable.ToListAsync();
		}

		public virtual Task<T> GetSingleAsync(
			Expression<Func<T, bool>> whereExpr = null,
			Expression<Func<IQueryable<T>, IIncludableQueryable<T, object>>> includeExpr = null)
		{
			var queryable = DbSet.AsQueryable();

			if (includeExpr != null)
			{
				queryable = includeExpr.Compile().Invoke(queryable);
			}

			return whereExpr != null
				? queryable.SingleOrDefaultAsync(whereExpr)
				: queryable.SingleOrDefaultAsync();
		}

		public Task<bool> AnyAsync(Expression<Func<T, bool>> whereExpr)
		{
			return DbSet.AnyAsync(whereExpr);
		}

		public Task<long> CountAsync(Expression<Func<T, bool>> whereExpr)
		{
			return DbSet.LongCountAsync(whereExpr);
		}

		public void Insert(T entity)
		{
			DbSet.Add(entity);
		}

		public void InsertRange(List<T> entity)
		{
			DbSet.AddRange(entity);
		}

		public void Remove(T entity)
		{
			DbSet.Remove(entity);
		}

	}
}
