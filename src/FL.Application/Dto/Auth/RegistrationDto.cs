using FL.Domain.Constant;
using System.Text.Json.Serialization;

namespace FL.Application.Dto.Auth
{
	public class RegistrationDto
	{
		public RegistrationDto()
		{
			DefaultRole = DefaultRoleConstant.Customer;
		}

		public string EmailAddress { get; set; }
		public string PhoneNumber { get; set; }
		public string Password { get; set; }

		[JsonIgnore]
		public string DefaultRole { get; set; }
	}
}
