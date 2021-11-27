using System.Threading.Tasks;

namespace FL.Domain.Interfaces
{
	public interface IUnitOfWork
	{
		TRepository GetRepository<TRepository>()
		  where TRepository : class;

		Task CommitAsync();
	}
}
