using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_TBS.DataAccess.Entities
{
	public class TicketBooking
	{
		[Key]
		public int Booking_id { get; set; }
		[Required]
		public int Match_Id { get; set; }
		[Required]
		public int user_Id { get; set; }
		[Required]
		public string Location { get; set; }
		[Required]
		public int Number_Of_Seats { get; set; }
		[Required]
		public string Class_Type { get; set; }
		//[Required]
		//public string Feedback { get; set; }
	}
}
