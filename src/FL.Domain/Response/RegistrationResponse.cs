namespace FL.Domain.Response
{
	public class RegistrationResponse : ResponseBase
	{
		public bool EmailSent { get; set; }
		public string EmailConfirmationToken { get; set; }
	}
}
