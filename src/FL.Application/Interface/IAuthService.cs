using FL.Application.Dto.Auth;
using FL.Domain.Response;
using System.Threading.Tasks;

namespace FL.Application.Interface
{
	public interface IAuthService
	{
		Task<LoginResponse> AuthenticateUserAsync(string email, string password);
		Task<bool> RegisterUserAsync(RegistrationDto dto);
		Task<bool> ConfirmEmail(string token, string email);

		#region FORGET PASSWORD RESET
		Task<string> GenerateForgetPasswordResetTokenAsync(string email);
		Task<ResponseBase> ForgetPasswordResetAsync(ForgetPasswordResetDto dto);
		#endregion

		#region OLD PASSWORD RESET
		Task<ResponseBase> ResetOldPassword(OldPasswordResetDto dto);
		#endregion

		Task<string> FindUserRoleByEmail(string email);
		Task<string> GetEmailConfirmationToken(string email);
	}
}
