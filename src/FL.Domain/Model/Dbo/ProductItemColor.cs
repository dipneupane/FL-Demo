namespace FL.Domain.Model.Dbo
{
	public class ProductItemColor
	{
		public long Id { get; set; }
		public long ProductItemId { get; set; }
		public int ColorId { get; set; }
	}
}
