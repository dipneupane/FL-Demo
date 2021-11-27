namespace FL.Application.Dto.Auth
{
	public class ForgetPasswordResetDto
	{
		public string Email { get; set; }
		public string Token { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }
	}
}
