using FL.Application.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FL.Application.Interface
{
	public interface IProductItemService
	{
		Task<List<ProductItemResponseDto>> GetAll();
		Task<List<ProductItemResponseDto>> SearchItem(ProductSearchRequestDto criteria);
	}
}
