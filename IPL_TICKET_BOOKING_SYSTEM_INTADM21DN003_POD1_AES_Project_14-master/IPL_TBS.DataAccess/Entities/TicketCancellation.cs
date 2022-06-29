using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_TBS.DataAccess.Entities
{
	 public class TicketCancellation
	{
		[Required(ErrorMessage = "Please enter SNo ")]
		[Display(Name = "Enter SNo")]
		//[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Key]
		public int SNo { get; set; }

		[Required]
		public int Match_Id { get; set; }

		[Required]
		public int User_Id { get; set; }

		[Required]
		public int Booking_Id { get; set; }

		[Required]
		public string Location { get; set; }

		[Required]
		public string Reason { get; set; }


	}
}
