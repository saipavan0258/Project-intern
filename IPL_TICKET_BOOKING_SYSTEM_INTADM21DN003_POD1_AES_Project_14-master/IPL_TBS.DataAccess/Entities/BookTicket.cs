using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_TBS.DataAccess.Entities
{
	public class BookTicket
	{
		[Key]
		public int Match_Id { get; set; }
		public int Number_Of_Seats { get; set; }
		public string Class_Type { get; set; }
		public string Feedback { get; set; }

	}
}
