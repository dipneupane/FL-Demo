using AutoMapper;
using FL.Application.Dto;
using FL.Application.Interface;
using FL.Domain.Interfaces;
using FL.Domain.Model.Dbo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FL.Application.Service
{
	public class ProductOrderService : IProductOrderService
	{
		private readonly IMapper _mapper;
		private readonly IUnitOfWork _unitOfWork;

		public ProductOrderService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_mapper = mapper;
			_unitOfWork = unitOfWork;
		}

		public async Task AddOrder(ProductOrderRequestDto dto)
		{
			var productItem = await _unitOfWork.GetRepository<IProductItemRepository>().GetSingleAsync(x => x.Id == dto.ProductItemId);

			if (productItem != null)
			{
				_unitOfWork.GetRepository<IProductOrderRepository>().Insert(new ProductOrder()
				{
					ProductItemId = productItem.Id,
					Quantity = dto.Quantity,
					Price = productItem.Price,
					AspNetUserId = dto.AspNetUserId
				});
				await _unitOfWork.CommitAsync();
			}
		}

		public async Task<List<ProductOrderHistoryResponseDto>> GetOrderHistory(string customerEmail)
		{
			var productOrderHistory = await _unitOfWork.GetRepository<IProductOrderRepository>()
				.GetAsync(x => x.AspNetUser.Email == customerEmail, includeExpr: (x => x.Include(x => x.ProductItem)));
			return _mapper.Map<List<ProductOrder>, List<ProductOrderHistoryResponseDto>>(productOrderHistory);
		}
	}
}