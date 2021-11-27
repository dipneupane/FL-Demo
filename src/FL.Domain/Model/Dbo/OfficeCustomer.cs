namespace FL.Domain.Model.Dbo
{
	public class OfficeCustomer
	{
		public long Id { get; set; }
		public string CompanyName { get; set; }
		public string CompanyAddress { get; set; }
		public string CompanyFax { get; set; }
		public string BuyerName { get; set; }
		public long AspNetUserId { get; set; }
	}
}
