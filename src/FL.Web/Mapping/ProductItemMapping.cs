using AutoMapper;
using FL.Application.Dto;
using FL.Domain.Constant;
using FL.Domain.Enum;
using FL.Domain.Model.Dbo;

namespace FL.Web.Mapping
{
	public class ProductItemMapping : Profile
	{
		public ProductItemMapping()
		{
			CreateMap<ProductItem, ProductItemResponseDto>()
				.ForMember(dest => dest.ProductCategory,
				opt => opt.MapFrom(src => src.ProductCategoryId == (int)ProductCategoryEnum.Corporate ? ProductCategoryConstant.Corporate :
										  src.ProductCategoryId == (int)ProductCategoryEnum.HomeOffice ? ProductCategoryConstant.HomeOffice : ProductCategoryConstant.Student));
		}
	}
}
