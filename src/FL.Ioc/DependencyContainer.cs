using FL.Application.Interface;
using FL.Application.Service;
using FL.Data.Repositories;
using FL.Data.UnitOfWork;
using FL.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FL.Ioc
{
	public class DependencyContainer
	{
		public static void RegisterServices(IServiceCollection services)
		{
			services.AddScoped<IUnitOfWork, UnitOfWork>();

			//FL.Services
			services.AddScoped<IAuthService, AuthService>();
			services.AddScoped<IProductItemService, ProductItemService>();
			services.AddScoped<IProductStockService, ProductStockService>();
			services.AddScoped<IProductOrderService, ProductOrderService>();

			//FL.Repositories
			services.AddScoped<IProductItemRepository, ProductItemRepository>();
			services.AddScoped<IProductStockRepository, ProductStockRepository>();
			services.AddScoped<IProductOrderRepository, ProductOrderRepository>();
		}
	}
}
