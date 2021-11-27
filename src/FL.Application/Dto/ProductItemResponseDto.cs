namespace FL.Application.Dto
{
	public class ProductItemResponseDto
	{
		public long Id { get; set; }
		public string ProductCategory { get; set; }
		public string Slug { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Size { get; set; }
		public string Weight { get; set; }
		public decimal Price { get; set; }
	}
}
