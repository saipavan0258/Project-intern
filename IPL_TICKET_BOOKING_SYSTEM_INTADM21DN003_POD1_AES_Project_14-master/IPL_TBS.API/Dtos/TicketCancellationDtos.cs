using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IPL_TBS.API.Dtos
{
	public class TicketCancellationDtos
	{ 

		public int SNo { get; set; }

	
		public int Match_Id { get; set; }


		public int User_Id { get; set; }


		public int Booking_Id { get; set; }

	
		public string Location { get; set; }


		public string Reason { get; set; }
	}
}