namespace FL.Domain.Response
{
	public class LoginResponse : ResponseBase
	{
		public string Jwt { get; set; }
		public string RefreshToken { get; set; }
	}
}
