using IPL_TBS.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_TBS.BusinessLogic
{
	public class LoginService
	{
		RegisterDBContext context = new RegisterDBContext();
		


		public int Login(string Email,string Password)
		{
			try
			{
				var query =(from obj in context.Registers where obj.Email ==Email && obj.Password==Password
						   select obj).FirstOrDefault();
				return query.UserId;
			}
		
			catch (Exception ex)
			{
				throw new IPLException("Unkown error while adding the user", ex);
			}

		}
	}
}
