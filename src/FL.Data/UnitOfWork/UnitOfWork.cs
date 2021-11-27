using System;
using FL.Data.Context;
using FL.Domain.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace FL.Data.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork, IDisposable
	{
		private readonly ApplicationDbContext _dbContext;
		private readonly IServiceProvider _serviceProvider;

		public UnitOfWork(ApplicationDbContext dataContext, IServiceProvider serviceProvider)
		{
			_dbContext = dataContext;
			_serviceProvider = serviceProvider;
			RequestedRepositories = new Dictionary<Type, object>();
		}

		protected IDictionary<Type, object> RequestedRepositories { get; private set; }

		public TRepository GetRepository<TRepository>()
		  where TRepository : class
		{
			var repositoryType = typeof(TRepository);

			if (RequestedRepositories.ContainsKey(repositoryType))
				return (TRepository)RequestedRepositories[repositoryType];

			var repository = _serviceProvider.GetRequiredService<TRepository>();
			RequestedRepositories.Add(repositoryType, repository);

			return repository;
		}

		public Task CommitAsync()
		{
			return _dbContext.SaveChangesAsync();
		}

		public void Dispose()
		{
			_dbContext?.Dispose();
		}
	}
}
