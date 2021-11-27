using FL.Data.Context;
using FL.Domain.Interfaces;
using FL.Domain.Model.Dbo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FL.Data.Repositories
{
public 	class ProductStockRepository : RepositoryBase<ProductStock>, IProductStockRepository
	{
		public ApplicationDbContext _context;
		public ProductStockRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}

		public Task<List<ProductStock>> GetOutOfStockItems()
		{
			throw new NotImplementedException();
		}
	}
}