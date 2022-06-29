using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IPL_TBS.API.Dtos
{
	public class Food_BeveragesDtos
	{
		public int Product_Id { get; set; }
		public string Product_Name { get; set; }
		public int Quantity { get; set; }
		public int Price { get; set; }
	}
}