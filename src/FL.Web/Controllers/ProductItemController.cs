using System;
using System.Threading.Tasks;
using FL.Application.Dto;
using FL.Application.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FL.Web.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ProductItemController : ControllerBase
	{
		private readonly IProductItemService _productItemService;
		private readonly ILogger<ProductItemController> _logger;

		public ProductItemController(
			ILogger<ProductItemController> logger,
			IProductItemService productItemService
		)
		{
			_logger = logger;
			_productItemService = productItemService;
		}

		[HttpGet("getAll")]
		public async Task<IActionResult> List()
		{
			try
			{
				var items = await _productItemService.GetAll();
				return Ok(items);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex.Message);
				return BadRequest();
			}
		}

		[HttpGet("search")]
		public async Task<IActionResult> List([FromQuery] int ProductCategoryId, decimal Price, string Name)
		{
			try
			{
				var items = await _productItemService.SearchItem(new ProductSearchRequestDto()
				{
					ProductCategoryId = ProductCategoryId,
					Price = Price,
					Name = Name
				});
				if (items.Count == 0) return NotFound();
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
