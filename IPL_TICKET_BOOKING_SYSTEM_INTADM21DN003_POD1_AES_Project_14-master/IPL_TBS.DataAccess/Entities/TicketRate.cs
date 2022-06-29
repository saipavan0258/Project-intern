using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_TBS.DataAccess.Entities
{
	public class TicketRate
	{
		[Required(ErrorMessage = "Please enter UserId (4-5) ")]
		//[Range(4, 5)]
		[Display(Name = "Enter  Match_Id")]
		[Key]
		public int Match_Id { get; set; }

		[Required]
		[Display(Name = "Enter  Gold_Rate")]
		public int Gold_Rate { get; set; }

		[Required]
		[Display(Name = "Enter  Diamond_Rate")]
		public int Diamond_Rate { get; set; }

		[Required]
		[Display(Name = "Enter  Platinum_Rate")]
		public int Platinum_Rate { get; set; }

		[Required]
		[Display(Name = "Enter  Gold_Count")]
		public int Gold_Count { get; set; }

		[Required]
		[Display(Name = "Enter  Diamond_Count")]
		public int Diamond_Count { get; set; }

		[Required]
		[Display(Name = "Enter  Platinum_Count")]
		public int Platinum_Count { get; set; }

	}
}