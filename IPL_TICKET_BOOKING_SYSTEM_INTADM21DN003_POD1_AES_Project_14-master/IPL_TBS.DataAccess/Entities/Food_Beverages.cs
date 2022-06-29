using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_TBS.DataAccess.Entities
{
	public class Food_Beverages
	{
		[Required]
		[Key]
		public int Product_Id { get; set; }
		[Required]
		public string Product_Name { get; set; }
		[Required]
		public int Quantity { get; set; }
		[Required]
		public int Price { get; set; }
	}
}