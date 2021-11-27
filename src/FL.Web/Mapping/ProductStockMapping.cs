using AutoMapper;
using FL.Application.Dto;
using FL.Domain.Model.Dbo;

namespace FL.Web.Mapping
{
	public class ProductStockMapping : Profile
	{
		public ProductStockMapping()
		{
			CreateMap<ProductStock, ProductStockResponseDto>()
				.ForMember(dest => dest.LastUpdatedDate, opt => opt.MapFrom(src => src.UpdatedDate))
				.ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.ProductItem.Name));
		}
	}
}
