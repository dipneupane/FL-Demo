using FL.Data.Context;
using FL.Domain.Interfaces;
using FL.Domain.Model.Dbo;

namespace FL.Data.Repositories
{
	public class ProductOrderRepository : RepositoryBase<ProductOrder>, IProductOrderRepository
	{
		public ApplicationDbContext _context;
		public ProductOrderRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}
	}
}