using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IPL_TBS.API.Dtos
{
	public class RegisterDtos
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhoneNumber { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public object UserId { get; internal set; }
	}
}