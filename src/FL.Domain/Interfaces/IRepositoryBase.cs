using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FL.Domain.Interfaces
{
	public interface IRepositoryBase<T> where T : class
	{
		Task<List<T>> GetAsync(
		  Expression<Func<T, bool>> whereExpr = null,
		  Expression<Func<IQueryable<T>, IIncludableQueryable<T, object>>> includeExpr = null,
		  Expression<Func<IQueryable<T>, IOrderedQueryable<T>>> orderExpr = null);

		Task<T> GetSingleAsync(
		  Expression<Func<T, bool>> whereExpr = null,
		  Expression<Func<IQueryable<T>, IIncludableQueryable<T, object>>> includeExpr = null);

		Task<bool> AnyAsync(Expression<Func<T, bool>> whereExpr);
		Task<long> CountAsync(Expression<Func<T, bool>> whereExpr);

		void Insert(T entity);
		void InsertRange(List<T> entity);
		void Remove(T entity);
	}
}
