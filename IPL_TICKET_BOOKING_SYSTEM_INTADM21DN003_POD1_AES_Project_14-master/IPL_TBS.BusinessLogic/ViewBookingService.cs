using IPL_TBS.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_TBS.BusinessLogic
{
	public class ViewBookingService
	{
		private readonly RegisterDBContext context;
		public ViewBookingService()
		{
			context = new RegisterDBContext();
		}
		public void Dispose()
		{
			context.Dispose();

		}
		public List<TicketBooking> GetBookReport(int id)
		{
			try
			{
				var items = from item in context.TicketBookings
							where item.Match_Id == id
							select item;
				return items.ToList();
			}
			catch (DbException ex)
			{
				throw new IPLException("Error reading data", ex);
			}
			catch (Exception ex)
			{
				throw new IPLException("unknown error while reading", ex);
			}
		}
	}
}
