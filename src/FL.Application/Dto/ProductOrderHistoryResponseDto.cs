namespace FL.Application.Dto
{
	public class ProductOrderHistoryResponseDto
	{
		public long Id { get; set; }
		public string ProductName { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }
		public decimal Vat { get; set; }
		public decimal Discount { get; set; }
		public decimal TotalPaid { get; set; }
	}
}
