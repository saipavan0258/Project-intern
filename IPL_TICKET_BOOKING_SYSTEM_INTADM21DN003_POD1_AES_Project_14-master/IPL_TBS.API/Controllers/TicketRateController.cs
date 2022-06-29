using System.Web.Http.Description;
using System.Web.Http;
using IPL_TBS.DataAccess.Entities;
using IPL_TBS.API.Dtos;
using System.Linq;
using System.Net.Http;
using System;
using System.Net;
using IPL_TBS.BusinessLogic;
//using IPL_TBS.API.Models;
//using System.Web.Http.Description;

namespace IPL_TBS.API.Controllers
{
	//[EnableCors("", "", "CreateAccount")]
	[RoutePrefix("api/TicketRate")]
	public class TicketRateController : ApiController
	{

		private readonly TicketRateService x;

		private readonly TicketRateDtos r;
		RegisterDBContext RegisterDBContext = new RegisterDBContext();
		public TicketRateController()
		{
			r = new TicketRateDtos();
		}



		// created successfully in postman(but not angular part)
		[ResponseType(typeof(TicketRateDtos))]
		public IHttpActionResult Add_TicketRate(TicketRateDtos register)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			TicketRate registerDt = new TicketRate();
			registerDt.Match_Id = register.Match_Id;
			registerDt.Gold_Rate = register.Gold_Rate;
			registerDt.Diamond_Rate = register.Diamond_Rate;
			registerDt.Platinum_Rate = register.Platinum_Rate;
			registerDt.Gold_Count = register.Gold_Count;
			registerDt.Diamond_Count = register.Diamond_Count;
			registerDt.Platinum_Count = register.Platinum_Count;
			RegisterDBContext.TicketRates.Add(registerDt);
			RegisterDBContext.SaveChanges();
			return CreatedAtRoute("DefaultApi", new { id = register.Match_Id }, register);
		}
		[HttpPut]
		[Route("{Match_Id}")]
		public IHttpActionResult UpdateDetails(int Match_Id, [FromBody] TicketRateDtos register)
		{
			try
			{
				if (!ModelState.IsValid)
					return BadRequest(ModelState);
				else
				{
					RegisterDBContext db = new RegisterDBContext();
					var obj = db.TicketRates.Find(Match_Id);
					if (obj == null)
						return NotFound();
					obj.Match_Id = Match_Id;
					obj.Gold_Rate = register.Gold_Rate;
					obj.Diamond_Rate = register.Diamond_Rate;
					obj.Platinum_Rate = register.Platinum_Rate;
					obj.Gold_Count = register.Gold_Count;
					obj.Diamond_Count = register.Diamond_Count;
					obj.Platinum_Count = register.Platinum_Count;
					var rows = db.SaveChanges();

					if (rows == 1)
						return Ok();
					return Conflict();
				}
			}
			catch (Exception ex)
			{
				return InternalServerError(ex);
			}

		}

	}
}