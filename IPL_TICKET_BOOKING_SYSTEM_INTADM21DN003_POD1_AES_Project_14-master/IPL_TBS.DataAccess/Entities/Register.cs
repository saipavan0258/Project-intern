using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_TBS.DataAccess.Entities
{
	public class Register
	{
		[Required(ErrorMessage ="Please enter Firstname ")]
		[RegularExpression("^[a-zA-Z]{3,}$", ErrorMessage = "Invalid Name")]
		[Display(Name ="Enter FirstName")]
		public string FirstName { get; set; }


		[Required(ErrorMessage = "Please enter Lastname ")]
		[Display(Name = "Enter LastName")]
		[RegularExpression("^[a-zA-Z]{3,}$",ErrorMessage ="Invalid Name")]
		public string LastName { get; set; }


		[Required]
		[RegularExpression("^[\\d]{10}$")]
		public string PhoneNumber { get; set; }


		[Required(ErrorMessage = "Please enter Valid UserId (5-6) ")]
		
		[Display(Name = "Enter Your UserId")]
		[Key]
		//[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int UserId { get; set; }


		[Required]
		[StringLength(6)]
		public string Password { get; set; }


		[Required]
		[DataType(DataType.EmailAddress)]
		public string  Email{ get; set; }

}
}
