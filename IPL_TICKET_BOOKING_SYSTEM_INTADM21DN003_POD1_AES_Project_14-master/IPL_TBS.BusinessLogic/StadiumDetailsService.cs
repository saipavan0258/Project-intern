using IPL_TBS.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPL_TBS.DataAccess;

namespace IPL_TBS.BusinessLogic
{
	public class StadiumDetailsService : IDisposable
	{
		private readonly RegisterDBContext context;
		public StadiumDetailsService()
		{
			context = new RegisterDBContext();
		}
		public void Dispose()
		{
			context.Dispose();
		}

		public void Post(string Name, string Location, string Capacity, string Home_To, string Ends)
		{
			try
			{
				StadiumDetails obj1 = new StadiumDetails();
				obj1.Name = Name;
				obj1.Location = Location;
				obj1.Capacity = Capacity;
				obj1.Home_To = Home_To;
				obj1.Ends = Ends;

				context.StadiumDetail.Add(obj1);
				context.SaveChanges();
			}
			catch (DbException ex)
			{
				throw new IPLException("Error Reading Data", ex);

			}
			catch (Exception ex)
			{
				throw new IPLException("Unknown Error while reading Stadiumdetails", ex);

			}
		}
	}
}