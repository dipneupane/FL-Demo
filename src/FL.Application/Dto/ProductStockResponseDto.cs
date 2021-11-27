using System;

namespace FL.Application.Dto
{
	public class ProductStockResponseDto
	{
		public long Id { get; set; }
		public string ProductName { get; set; }
		public DateTime LastUpdatedDate { get; set; }
	}
}
