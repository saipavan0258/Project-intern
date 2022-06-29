using IPL_TBS.API.Dtos;
using IPL_TBS.BusinessLogic;
using IPL_TBS.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IPL_TBS.API.Controllers
{
    public class LoginController : ApiController
    {
		LoginService loginService = new LoginService();
		[HttpPost]
		public IHttpActionResult Login(LoginDtos loginDtos)
		{
			if(!ModelState.IsValid)
			{
				return BadRequest();
			}
			else
			{
				var obj = new Register();
				obj.Email = loginDtos.Email;
				obj.Password = loginDtos.Password;
				var result = loginService.Login(obj.Email, obj.Password);
				return Ok(result);
			}
		}
    }
}
