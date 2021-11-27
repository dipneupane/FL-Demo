namespace FL.Domain.Model.Dbo
{
	public class ProductItem
	{
		public long Id { get; set; }
		public int ProductCategoryId { get; set; }
		public string Slug { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Size { get; set; }
		public string Weight { get; set; }
		public decimal Price { get; set; }
	}
}
