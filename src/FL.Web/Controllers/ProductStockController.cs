using FL.Application.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace FL.Web.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ProductStockController : ControllerBase
	{
		private readonly IProductStockService _productStockService;
		private readonly ILogger<ProductStockController> _logger;

		public ProductStockController(
			ILogger<ProductStockController> logger,
			IProductStockService productStockService
		)
		{
			_logger = logger;
			_productStockService = productStockService;
		}

		[HttpGet("getAllOutOfStock")]
		public async Task<IActionResult> GetAllOutOfStock()
		{
			_logger.LogError("This is the error test");
			try
			{
				var items = await _productStockService.GetOutOfStockItems();
				return Ok(items);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex.Message);
				return BadRequest();
			}
		}
	}
}
