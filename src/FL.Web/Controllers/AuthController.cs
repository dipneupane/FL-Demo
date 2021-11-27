using FL.Application.Dto.Auth;
using FL.Application.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace FL.Web.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AuthController : ControllerBase
	{
		private readonly IConfiguration _conf;
		private readonly IAuthService _authService;
		private readonly ILogger<AuthController> _logger;
		private readonly IWebHostEnvironment _webHostEnvironment;

		public AuthController(
			IConfiguration conf,
			IAuthService authService,
			ILogger<AuthController> logger,
			IWebHostEnvironment webHostEnvironment
		)
		{
			_conf = conf;
			_logger = logger;
			_authService = authService;
			_webHostEnvironment = webHostEnvironment;
		}

		[HttpPost("authenticate")]
		public async Task<IActionResult> AuthenticateUser([FromBody] LoginDto dto)
		{
			var response = await _authService.AuthenticateUserAsync(dto.Email, dto.Password);
			return Ok(response);
		}

		[HttpPost("register")]
		public async Task<IActionResult> RegisterUser([FromBody] RegistrationDto dto)
		{
			var response = await _authService.RegisterUserAsync(dto);

			if (response)
			{
				//TODO:: send email confirmation email from here
			}
			return Ok(response);
		}
	}
}
