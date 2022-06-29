using System.Web.Http.Description;
using System.Web.Http;
using IPL_TBS.DataAccess.Entities;
using IPL_TBS.API.Dtos;
using System;

namespace IPL_TBS.API.Controllers
{
	//[EnableCors("", "", "CreateAccount")]
	[RoutePrefix("api/StadiumDetails")]
	public class StadiumDetailsController : ApiController
	{



		private readonly StadiumDetailsDtos r;
		RegisterDBContext db = new RegisterDBContext();
		public StadiumDetailsController()
		{
			r = new StadiumDetailsDtos();
		}


		[ResponseType(typeof(StadiumDetailsDtos))]
		public IHttpActionResult Add_StadiumDetails(StadiumDetailsDtos register)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			StadiumDetails registerDt = new StadiumDetails();
			//registerDt.Match_Id = register.Match_Id;
			registerDt.Location = register.Location;
			registerDt.Name = register.Name;
			registerDt.Capacity = register.Capacity;
			registerDt.Home_To = register.Home_To;
			registerDt.Ends = register.Ends;
			db.StadiumDetail.Add(registerDt);
			var rows=db.SaveChanges();
			if (rows == 1)
				return Ok();
			return Conflict();
			//return CreatedAtRoute("DefaultApi", new { id = register.Match_Id }, register);
		}

		


		[HttpPut]
		[Route("{Match_Id}")]
		public IHttpActionResult UpdateDetails(int Match_Id, [FromBody] StadiumDetailsDtos register)
		{
			try
			{
				if (!ModelState.IsValid)
					return BadRequest(ModelState);
				else
				{
					RegisterDBContext db = new RegisterDBContext();
					var obj = db.StadiumDetail.Find(Match_Id);
					if (obj == null)
						return NotFound();
					obj.Match_Id = Match_Id;
					obj.Location = register.Location;
					obj.Name = register.Name;
					obj.Capacity = register.Capacity;
					obj.Home_To = register.Home_To;
					obj.Ends =register.Ends;
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