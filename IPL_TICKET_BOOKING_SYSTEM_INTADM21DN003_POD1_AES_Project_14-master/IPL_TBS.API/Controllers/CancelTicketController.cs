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
	[RoutePrefix("api/CancelTicket")]
	public class CancelTicketController : ApiController
    {
		private readonly TicketCancellationDtos r;
		RegisterDBContext db = new RegisterDBContext();
		public CancelTicketController()
		{
			r = new TicketCancellationDtos();
		}



		// created successfully in postman(but not angular part)
		[ResponseType(typeof(BookTicketDtos))]
		public IHttpActionResult Add_BookTicket(TicketCancellationDtos register)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			TicketCancellation registerDt = new TicketCancellation();
			registerDt.Match_Id = register.Match_Id;
			registerDt.Location = register.Location;
			registerDt.Booking_Id = register.Booking_Id;
			registerDt.User_Id = register.User_Id;
			registerDt.Reason = register.Reason;

			//registerDt.Feedback = register.Feedback;
			db.TicketCancellations.Add(registerDt);
			db.SaveChanges();
			return CreatedAtRoute("DefaultApi", new { id = register.Match_Id }, register);
		}
	}
}
