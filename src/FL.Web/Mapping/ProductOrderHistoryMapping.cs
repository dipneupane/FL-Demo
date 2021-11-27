using AutoMapper;
using FL.Application.Dto;
using FL.Domain.Model.Dbo;

namespace FL.Web.Mapping
{
	public class ProductOrderHistoryMapping : Profile
	{
		public ProductOrderHistoryMapping()
		{
			CreateMap<ProductOrder, ProductOrderHistoryResponseDto>()
				.ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.ProductItem.Name))
				.ForMember(dest => dest.TotalPaid, opt => opt.MapFrom(src => (src.Price + src.Vat) - src.Discount));
		}
	}
}
