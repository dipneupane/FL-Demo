using FL.Application.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FL.Application.Interface
{
	public interface IProductOrderService
	{
		Task AddOrder(ProductOrderRequestDto dto);
		Task<List<ProductOrderHistoryResponseDto>> GetOrderHistory(string customerEmail);
	}
}
