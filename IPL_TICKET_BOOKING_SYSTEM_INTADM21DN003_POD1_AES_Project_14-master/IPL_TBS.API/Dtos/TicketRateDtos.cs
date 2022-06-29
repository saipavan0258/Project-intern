using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IPL_TBS.API.Dtos
{
	public class TicketRateDtos
	{
		public int Match_Id { get; set; }
		public int Gold_Rate { get; set; }
		public int Diamond_Rate { get; set; }
		public int Platinum_Rate { get; set; }
		public int Gold_Count { get; set; }
		public int Diamond_Count { get; set; }
		public int Platinum_Count { get; set; }
	}
}