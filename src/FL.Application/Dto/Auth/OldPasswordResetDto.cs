namespace FL.Application.Dto.Auth
{
	public class OldPasswordResetDto
	{
		public string Email { get; set; }
		public string CurrentPassword { get; set; }
		public string NewPassword { get; set; }
	}
}
