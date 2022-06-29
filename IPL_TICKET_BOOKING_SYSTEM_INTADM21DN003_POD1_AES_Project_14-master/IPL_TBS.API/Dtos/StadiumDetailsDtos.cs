using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IPL_TBS.API.Dtos
{
	public class StadiumDetailsDtos
	{
		public int Match_Id { get; set; }
		public string Location { get; set; }
		public string Name { get; set; }
		public string Capacity { get; set; }
		public string Home_To { get; set; }
		public string Ends { get; set; }
	}
}