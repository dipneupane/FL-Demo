using FL.Application.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FL.Application.Interface
{
	public interface IProductStockService
	{
		Task<List<ProductStockResponseDto>> GetOutOfStockItems();
	}
}
