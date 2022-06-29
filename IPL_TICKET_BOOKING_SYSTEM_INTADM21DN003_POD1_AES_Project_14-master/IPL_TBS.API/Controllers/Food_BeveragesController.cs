using System.Web.Http.Description;
using System.Web.Http;
using IPL_TBS.DataAccess.Entities;
using IPL_TBS.API.Dtos;
using System;
//using IPL_TBS.API.Models;
//using System.Web.Http.Description;

namespace IPL_TBS.API.Controllers
{
	//[EnableCors("", "", "CreateAccount")]
	[RoutePrefix("api/Food_Beverages")]
	public class Food_BeveragesController : ApiController
	{



		private readonly Food_BeveragesDtos r;
		RegisterDBContext db = new RegisterDBContext();
		public Food_BeveragesController()
		{
			r = new Food_BeveragesDtos();
		}



		// created successfully in postman(but not angular part)
		[ResponseType(typeof(Food_BeveragesDtos))]
		public IHttpActionResult Add_Food_Beverages(Food_BeveragesDtos register)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			Food_Beverages registerDt = new Food_Beverages();
			//registerDt.Product_Id = register.Product_Id;
			registerDt.Product_Name = register.Product_Name;
			registerDt.Quantity = register.Quantity;
			registerDt.Price = register.Price;

			db.Food_Beverages.Add(registerDt);
			db.SaveChanges();
			return CreatedAtRoute("DefaultApi", new { id = register.Product_Id }, register);
		}

		[HttpPut]
		[Route("{Product_Id}")]
		public IHttpActionResult UpdateDetails(int Product_Id, [FromBody] Food_BeveragesDtos register)
		{
			try
			{
				if (!ModelState.IsValid)
					return BadRequest(ModelState);
				else
				{
					RegisterDBContext db = new RegisterDBContext();
					var obj = db.Food_Beverages.Find(Product_Id);
					if (obj == null)
						return NotFound();
					obj.Product_Id = Product_Id;
					obj.Product_Name = register.Product_Name;
					obj.Quantity = register.Quantity;
					obj.Price = register.Price;
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