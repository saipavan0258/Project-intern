using IPL_TBS.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IPL_TBS.BusinessLogic
{
	public class BookTicketService : IDisposable
	{
		private readonly RegisterDBContext context;
		public BookTicketService()
		{
			context = new RegisterDBContext();
		}
		public void Dispose()
		{
			context.Dispose();

		}
		public void post(int matchId, int number_of_seats, string class_Type, string Feedback)
		{
			try
			{
				BookTicket obj = new BookTicket();
				obj.Match_Id = matchId;
				obj.Number_Of_Seats = number_of_seats;
				obj.Class_Type = class_Type;
				obj.Feedback = Feedback;

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
