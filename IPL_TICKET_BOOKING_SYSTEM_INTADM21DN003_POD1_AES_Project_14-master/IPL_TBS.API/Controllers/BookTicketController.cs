using IPL_TBS.API.Dtos;
using IPL_TBS.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace IPL_TBS.API.Controllers
{
	//[EnableCors("", "", "CreateAccount")]
	[RoutePrefix("api/BookTicket")]
	public class BookTicketController : ApiController
    {

		private readonly BookTicketDtos r;
		RegisterDBContext db = new RegisterDBContext();
		public BookTicketController()
		{
			r = new BookTicketDtos();
		}



		// created successfully in postman(but not angular part)
		[ResponseType(typeof(BookTicketDtos))]
		public IHttpActionResult Add_BookTicket(BookTicketDtos register)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
		    TicketBooking registerDt = new TicketBooking();
			registerDt.Match_Id = register.Match_Id;
			registerDt.user_Id = registerDt.user_Id;
			registerDt.Number_Of_Seats = register.Number_Of_Seats;
			registerDt.Class_Type = register.Class_Type;
			registerDt.Location = register.Location;

			//registerDt.Feedback = register.Feedback;
			db.TicketBookings.Add(registerDt);
			db.SaveChanges();
			return CreatedAtRoute("DefaultApi", new { id = register.Match_Id }, register);
		}

	}
}
