using FL.Data.Context;
using FL.Domain.Interfaces;
using FL.Domain.Model.Dbo;

namespace FL.Data.Repositories
{
	public class ProductItemRepository : RepositoryBase<ProductItem>, IProductItemRepository
	{
		public ApplicationDbContext _context;
		public ProductItemRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}
	}
}