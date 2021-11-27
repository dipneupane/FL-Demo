using FL.Application.Dto.Auth;
using FL.Application.Interface;
using FL.Domain.Constant;
using FL.Domain.Interfaces;
using FL.Domain.Model.Auth;
using FL.Domain.Response;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FL.Application.Service
{
	public class AuthService : IAuthService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IConfiguration _configuration;
		private readonly UserManager<User> _userManager;
		private readonly SignInManager<User> _signInManager;

		public AuthService(
			IUnitOfWork unitOfWork,
			IConfiguration configuration,
			UserManager<User> userManager,
			SignInManager<User> signInManager
		)
		{
			_unitOfWork = unitOfWork;
			_userManager = userManager;
			_signInManager = signInManager;
			_configuration = configuration;
		}

		public async Task<LoginResponse> AuthenticateUserAsync(string email, string password)
		{
			LoginResponse response = new LoginResponse();

			User user = await _userManager.FindByEmailAsync(email);

			if (user == null)
			{
				response.Errors.Add("User not found.");
				return response;
			}

			SignInResult signInResult = await _signInManager.PasswordSignInAsync(email, password, false, false);
			if (signInResult.Succeeded)
			{
				response.Jwt = _generatetoken(user);
				response.RefreshToken = ""; //:: TODO
				response.Success = signInResult.Succeeded;
			}
			else
			{
				if (signInResult.IsLockedOut)
					response.Errors.Add(@$"Your account has been locked out due to multiple failed login attampts. Please try after 5 minutes.");
				else
				{
					string messageSuffix = user.AccessFailedCount > 3 ? @$"{7 - user.AccessFailedCount} login attampt left out of 7." : null;
					response.Errors.Add(@$"Username or Password doesn't match. {messageSuffix}");
				}
			}

			return response;
		}

		public async Task<bool> RegisterUserAsync(RegistrationDto dto)
		{
			IdentityResult createUserIdentityResult = await _userManager.CreateAsync(new User()
			{
				UserName = dto.EmailAddress,
				Email = dto.EmailAddress,
				PhoneNumber = dto.PhoneNumber
			}, dto.Password);

			if (createUserIdentityResult.Succeeded)
			{
				User newUser = await _userManager.FindByEmailAsync(dto.EmailAddress);
				IdentityResult createRoleIdentityResult = await _userManager.AddToRoleAsync(newUser, dto.DefaultRole);
				return createRoleIdentityResult.Succeeded;
			}

			return false;
		}

		public async Task<bool> ConfirmEmail(string token, string email)
		{
			var user = await _userManager.FindByEmailAsync(email);
			if (user == null) return false;

			IdentityResult result = await _userManager.ConfirmEmailAsync(user, token);
			return result.Succeeded;
		}

		#region FORGET PASSWORD RESET
		public async Task<string> GenerateForgetPasswordResetTokenAsync(string email)
		{
			var user = await _userManager.FindByEmailAsync(email);
			return await _userManager.GeneratePasswordResetTokenAsync(user);
		}
		public async Task<ResponseBase> ForgetPasswordResetAsync(ForgetPasswordResetDto dto)
		{
			ResponseBase response = new ResponseBase();
			User user = await _userManager.FindByEmailAsync(dto.Email);

			if (user == null)
			{
				response.Errors.Add("User not found.");
				return response;
			}

			IdentityResult identityResult = await _userManager.ResetPasswordAsync(user, dto.Token, dto.Password);
			response.Success = identityResult.Succeeded;

			if (!identityResult.Succeeded)
			{
				identityResult.Errors?.ToList().ForEach(x => response.Errors.Add(x.Description));
			}
			return response;
		}
		#endregion

		#region OLD PASSWORD RESET
		public async Task<ResponseBase> ResetOldPassword(OldPasswordResetDto dto)
		{
			ResponseBase response = new ResponseBase();
			User user = await _userManager.FindByEmailAsync(dto.Email);
			if (user == null)
			{
				response.Errors.Add("User not found");
				return response;
			}

			var resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
			IdentityResult identityResult = await _userManager.ResetPasswordAsync(user, resetToken, dto.NewPassword);
			response.Success = identityResult.Succeeded;

			if (!identityResult.Succeeded)
			{
				identityResult.Errors?.ToList().ForEach(x => response.Errors.Add(x.Description));
			}
			return response;
		}
		#endregion

		public async Task<string> FindUserRoleByEmail(string email)
		{
			var user = await _userManager.FindByEmailAsync(email);
			var roles = await _userManager.GetRolesAsync(user);
			return roles.FirstOrDefault();
		}
		public async Task<string> GetEmailConfirmationToken(string email)
		{
			var user = await _userManager.FindByEmailAsync(email);
			string emailConfirmationToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
			return HttpUtility.UrlEncode(emailConfirmationToken);
		}

		#region PRIVATE FUNCTIONS
		private string _generatetoken(User user)
		{
			string userRole = _userManager.GetRolesAsync(user).GetAwaiter().GetResult()[0];
			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration[JwtSettingConstant.SecretKey]));
			var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

			List<Claim> claims = new List<Claim>
			{
				new Claim (ClaimTypesConstant.Role, userRole),
				new Claim(ClaimTypesConstant.Email, user.Email),
				new Claim(ClaimTypesConstant.NameId, user.Id.ToString()),
				new Claim(ClaimTypesConstant.IsEmailConfirmed, user.EmailConfirmed.ToString()),
			};

			var token = new JwtSecurityToken(
				issuer: _configuration[JwtSettingConstant.Issuer],
				audience: _configuration[JwtSettingConstant.Audience],
				claims: claims,
				expires: DateTime.Now.AddMinutes(Convert.ToDouble(_configuration[JwtSettingConstant.ExpiryTimeInMin])),
				signingCredentials: credentials);

			return new JwtSecurityTokenHandler().WriteToken(token);
		}
		#endregion
	}
}
