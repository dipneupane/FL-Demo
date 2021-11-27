using AutoMapper;
using FL.Application.Dto;
using FL.Application.Interface;
using FL.Domain.Interfaces;
using FL.Domain.Model.Dbo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FL.Application.Service
{
	public class ProductItemService : IProductItemService
	{
		private readonly IMapper _mapper;
		private readonly IUnitOfWork _unitOfWork;

		public ProductItemService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_mapper = mapper;
			_unitOfWork = unitOfWork;
		}

		public async Task<List<ProductItemResponseDto>> GetAll()
		{
			var productItems = await _unitOfWork.GetRepository<IProductItemRepository>().GetAsync();
			return _mapper.Map<List<ProductItem>, List<ProductItemResponseDto>>(productItems);
		}

		public async Task<List<ProductItemResponseDto>> SearchItem(ProductSearchRequestDto criteria)
		{
			var productItems = await _unitOfWork.GetRepository<IProductItemRepository>()
				.GetAsync(x => x.ProductCategoryId == criteria.ProductCategoryId || x.Price == criteria.Price || x.Name == criteria.Name);
			return _mapper.Map<List<ProductItem>, List<ProductItemResponseDto>>(productItems);
		}
	}
}
