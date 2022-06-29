using IPL_TBS.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_TBS.BusinessLogic
{


	public class RegistrationService : IDisposable
	{
		private readonly RegisterDBContext context;
		public RegistrationService()
		{
			context = new RegisterDBContext();
		}
		public void Dispose()
		{
			context.Dispose();

		}
		public void post(string email, string password, string phonenumber, string firstname, string lastname)
		{
			try
			{
				Register obj = new Register();
				obj.Email = email;
				obj.Password = password;
				obj.PhoneNumber = phonenumber;
				obj.FirstName = firstname;
				obj.LastName = lastname;
				context.Registers.Add(obj);
				context.SaveChanges();
			}
			catch (DbException ex)
			{
				throw new IPLException(" Error in adding the user ", ex);
			}
			catch (Exception ex)
			{
				throw new IPLException("Unkown error while adding the user", ex);
			}
		}

	}

}