using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_TBS.DataAccess.Entities
{
	public class StadiumDetails
	{

		[Required(ErrorMessage = "Please enter MatchId ")]
		[Display(Name = "Enter MatchID")]
		//[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Key]
		public int Match_Id { get; set; }

		[Required(ErrorMessage = "Please enter Location ")]
		[Display(Name = "Enter Location")]
		public string Location { get; set; }

		[Required(ErrorMessage = "Please enter StadiumName ")]
		[Display(Name = "Enter StadiumName")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Please enter Capacity ")]
		[Display(Name = "Enter Capacity")]
		public string Capacity { get; set; }

		[Required(ErrorMessage = "Please enter HomeGround ")]
		[Display(Name = "Enter HomeGround")]
		public string Home_To { get; set; }

		[Required(ErrorMessage = "Please enter Ends ")]
		[Display(Name = "Enter Ends")]
		public string Ends { get; set; }
	}
}
