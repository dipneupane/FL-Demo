using AutoMapper;
using FL.Application.Dto;
using FL.Application.Interface;
using FL.Domain.Interfaces;
using FL.Domain.Model.Dbo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FL.Application.Service
{
	public class ProductStockService : IProductStockService
	{
		private readonly IMapper _mapper;
		private readonly IUnitOfWork _unitOfWork;

		public ProductStockService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_mapper = mapper;
			_unitOfWork = unitOfWork;
		}

		public async Task<List<ProductStockResponseDto>> GetOutOfStockItems()
		{
			var productStocks = await _unitOfWork.GetRepository<IProductStockRepository>().GetAsync(x => x.Quantity == 0);
			return _mapper.Map<List<ProductStock>, List<ProductStockResponseDto>>(productStocks);
		}
	}
}
