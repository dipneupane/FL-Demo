namespace FL.Application.Dto
{
	public class ProductOrderRequestDto
	{
		public long ProductItemId { get; set; }
		public int Quantity { get; set; }
		public long AspNetUserId { get; set; }
	}
}
