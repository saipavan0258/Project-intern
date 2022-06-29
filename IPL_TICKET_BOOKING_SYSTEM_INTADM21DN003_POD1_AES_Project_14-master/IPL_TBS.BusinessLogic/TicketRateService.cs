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
	public class TicketRateService : IDisposable
	{
		private readonly RegisterDBContext context;
		public TicketRateService()
		{
			context = new RegisterDBContext();
		}
		public void Dispose()
		{
			context.Dispose();
		}

		public void Post(int Gold_Rate, int Diamond_Rate, int Platinum_Rate, int Gold_Count, int Diamond_Count, int Platinum_Count)
		{
			try
			{
				TicketRate obj1 = new TicketRate();
				obj1.Gold_Rate = Gold_Rate;
				obj1.Diamond_Rate = Diamond_Rate;
				obj1.Platinum_Rate = Platinum_Rate;
				obj1.Gold_Count = Gold_Count;
				obj1.Diamond_Count = Diamond_Count;
				obj1.Platinum_Count = Platinum_Count;

				context.TicketRates.Add(obj1);
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