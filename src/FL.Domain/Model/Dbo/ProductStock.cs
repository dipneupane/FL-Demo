using System;

namespace FL.Domain.Model.Dbo
{
	public class ProductStock
	{
		public long Id { get; set; }
		public long ProductItemId { get; set; }
		public int Quantity { get; set; }
		public DateTime UpdatedDate { get; set; }

		//navigation property
		public ProductItem ProductItem { get; set; }
	}
}
