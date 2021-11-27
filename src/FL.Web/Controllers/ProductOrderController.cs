using FL.Application.Dto;
using FL.Application.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace FL.Web.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ProductOrderController : ControllerBase
	{
		private readonly IProductOrderService _productOrderService;
		private readonly ILogger<ProductOrderController> _logger;

		public ProductOrderController(
			ILogger<ProductOrderController> logger,
			IProductOrderService productOrderService
		)
		{
			_logger = logger;
			_productOrderService = productOrderService;
		}

		[HttpPost("addOrder")]
		public async Task<IActionResult> AddOrder([FromBody] ProductOrderRequestDto dto)
		{
			try
			{
				await _productOrderService.AddOrder(dto);
				return Ok();
			}
			catch (Exception ex)
			{
				_logger.LogError(ex.Message);
				return BadRequest();
			}
		}

		[HttpGet("getOrderHistory")]
		public async Task<IActionResult> GetOrderHistory([FromQuery] string customerEmail)
		{
			try
			{
				var orderHistory = await _productOrderService.GetOrderHistory(customerEmail);
				return Ok(orderHistory);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex.Message);
				return BadRequest();
			}
		}
	}
}