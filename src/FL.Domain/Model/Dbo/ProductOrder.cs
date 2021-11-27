using FL.Domain.Model.Auth;

namespace FL.Domain.Model.Dbo
{
	public class ProductOrder
	{
		public long Id { get; set; }
		public long ProductItemId { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }
		public decimal Vat { get; set; }
		public decimal Discount { get; set; }
		public long AspNetUserId { get; set; }

		//navigation property
		public ProductItem ProductItem { get; set; }
		public User AspNetUser { get; set; }
	}
}
