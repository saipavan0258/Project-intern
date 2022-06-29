using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_TBS.DataAccess.Entities
{
	public class MatchDetails
	{
		[Required(ErrorMessage = "Please enter MatchId ")]
		[Display(Name = "Enter MatchID")]
		//[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Key]
		public int Match_Id { get; set; }


		[Required(ErrorMessage = "Please enter Location ")]
		[Display(Name = "Enter Location")]
		public string Location { get; set; }


		[Required(ErrorMessage = "Please enter Date ")]
		[Display(Name = "Enter Date")]
		public string Date { get; set; }


		[Required(ErrorMessage = "Please enter Battle ")]
		[Display(Name = "Enter Battle")]
		public string Battle { get; set; }

	}
}