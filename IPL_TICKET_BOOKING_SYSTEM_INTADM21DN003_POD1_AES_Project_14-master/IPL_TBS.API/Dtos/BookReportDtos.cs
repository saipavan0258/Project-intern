using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IPL_TBS.API.Dtos
{
	public class BookReportDtos
	{

		public int Booking_id { get; set; }
		
		public int Match_Id { get; set; }
		
		public int user_Id { get; set; }
		
		public string Location { get; set; }
		
		public int Number_Of_Seats { get; set; }
		
		public string Class_Type { get; set; }
		
		//public string Feedback { get; set; }
	}
}