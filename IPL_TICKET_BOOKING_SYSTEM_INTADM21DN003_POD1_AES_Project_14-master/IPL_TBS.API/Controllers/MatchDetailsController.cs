using System.Web.Http.Description;

using System.Web.Http;
using IPL_TBS.DataAccess.Entities;
//using IPL_TBS.API.Models;
using IPL_TBS.API.Dtos;
using System;
using System.Net.Http;
using System.Linq;
using System.Net;
using System.Data.Common;
using IPL_TBS.BusinessLogic;
using System.Collections.Generic;
//using System.Web.Http.Description;

namespace IPL_TBS.API.Controllers
{
	
	[RoutePrefix("api/MatchDetails")]
	public class MatchDetailsController : ApiController
	{



		private readonly MatchDetailsDtos r;
		RegisterDBContext db = new RegisterDBContext();
		public MatchDetailsController()
		{
			r = new MatchDetailsDtos();
		}

		[ResponseType(typeof(MatchDetailsDtos))]
		public IHttpActionResult Add_MatchDetails(MatchDetailsDtos register)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			MatchDetails registerDt = new MatchDetails();
			//registerDt.Match_Id = register.Match_Id;
			registerDt.Location = register.Location;
			registerDt.Date = register.Date;
			registerDt.Battle = register.Battle;
			db.MatchDetail.Add(registerDt);
			db.SaveChanges();
			return CreatedAtRoute("DefaultApi", new { id = register.Match_Id }, register);
		}



		[HttpPut]
		[Route("{Match_Id}")]
		public IHttpActionResult UpdateDetails(int Match_Id, [FromBody] MatchDetailsDtos register)
		{
			try
			{
				if (!ModelState.IsValid)
					return BadRequest(ModelState);
				else
				{
					RegisterDBContext db = new RegisterDBContext();
					var obj = db.MatchDetail.Find( Match_Id);
					if (obj == null)
						return NotFound();
					obj.Match_Id = Match_Id;
					obj.Location = register.Location;
					obj.Date = register.Date;
					obj.Battle = register.Battle;	
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

		[HttpGet]
		public HttpResponseMessage GetActiveItems()
		{
			try
			{
				MatchDetailsService obj = new MatchDetailsService();
				var items = obj.GetAllActive();
				List<MatchDetailsDtos> dtos = new List<MatchDetailsDtos>();
				foreach (var item in items)
				{
					dtos.Add(new MatchDetailsDtos { Match_Id = item.Match_Id, Location = item.Location, Date = item.Date, Battle = item.Battle });
				}
				return Request.CreateResponse(HttpStatusCode.OK, dtos);
			}
			catch (DbException ex)
			{
				return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
			}
		}





	}
}