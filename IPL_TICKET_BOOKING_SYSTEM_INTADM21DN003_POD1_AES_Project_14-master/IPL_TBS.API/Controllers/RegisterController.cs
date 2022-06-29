
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

using System.Web.Http;
using IPL_TBS.DataAccess.Entities;
using IPL_TBS.API.Dtos;
//using System.Web.Http.Description;

namespace IPL_TBS.API.Controllers
{
	//[EnableCors("*", "*", "CreateAccount")]
	[RoutePrefix("api/register")]
	public class RegisterController : ApiController
    {
	
		private readonly RegisterDtos r;
		RegisterDBContext db = new RegisterDBContext();
		public RegisterController()
		{
		 r = new RegisterDtos();
		}
	


		// created successfully in postman(but not angular part)
		 [ResponseType(typeof(RegisterDtos))]
		public IHttpActionResult CreateAccount(RegisterDtos register)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
		    Register registerDt = new Register();
			registerDt.Email = register.Email;
			registerDt.Password= register.Password;
			registerDt.PhoneNumber = register.PhoneNumber;
			registerDt.FirstName = register.FirstName;
			registerDt.LastName = register.LastName;
			db.Registers.Add(registerDt);
			db.SaveChanges();
			return CreatedAtRoute("DefaultApi", new { id = register.UserId }, register);
		}
		

	}
}
/*	[HttpPost]
		[ResponseType(typeof(Register))]
		public IHttpActionResult CreateAccount([FromBody] Register model)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			IHttpActionResult response = NotFound();

			using (var context = new RegisterDBContext())
			{
				if (context.Registers.Any(u => u.Email == model.Email && u.Password == model.Password))
				{
					var result = (from user in context.Registers
								  where user.Email == model.Email
								  select new { user.UserId, user.Email}).Single();
					response = Ok(new RegisterResponse { UserId = result.UserId, Email = result.Email });
				}
			}
			return response;
		}*/
/*[HttpPost]
public IHttpActionResult CreateAccount(Register cvm)
{

	try
	{

		if(r.UserId==1)
		{
			r.FirstName =cvm.FirstName;
			r.LastName = cvm.LastName;
			r.Email = cvm.Email;
			r.PhoneNumber = cvm.PhoneNumber;
			r.Password = cvm.Password;
			db.Registers.Add(r);
			var rows = db.SaveChanges();
			/*if (rows == 1)
			{
			  return StatusCode(HttpStatusCode.Created);
						 }
			//return StatusCode(HttpStatusCode.BadRequest);
			return StatusCode(HttpStatusCode.Created);
		}
	}
	catch(Exception ex)
	{
		return InternalServerError();
	}
	return StatusCode(HttpStatusCode.BadRequest);
}*/
/*	[Route]
	public HttpResponseMessage Login(Register log)
	{
		RegisterDBContext db = new RegisterDBContext();
		var Obj=db.
	}*/
/*	
	[HttpPost]
	[ResponseType(typeof(Register))]
	public IHttpActionResult CreateAccount([FromBody]Register register)
	{
		try
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			int row = r.Add(register.FirstName, register.LastName, register.Email, register.PhoneNumber, register.Password);
			if (row==0)
			{
				return BadRequest("Change")
			}
		}
		catch (Exception ex)
		{
			return InternalServerError();
		}
		db.Registers.Add(register);
		db.SaveChanges();
		return CreatedAtRoute("DefaultApi", new { id = register.UserId }, register);
	}*/
