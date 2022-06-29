using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IPL_TBS.API.Dtos
{
	public class MatchDetailsDtos
	{
		public int Match_Id { get; set; }
		public string Location { get; set; }
		public string Date { get; set; }
		public string Battle { get; set; }
	}
}