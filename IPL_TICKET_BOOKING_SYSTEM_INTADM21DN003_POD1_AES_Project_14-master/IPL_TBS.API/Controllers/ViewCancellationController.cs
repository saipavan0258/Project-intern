using IPL_TBS.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IPL_TBS.API.Dtos;
using IPL_TBS.DataAccess.Entities;

namespace IPL_TBS.API.Controllers
{
		[RoutePrefix("api/viewCancellation")]
		public class ViewCancellationController : ApiController
		{
			[HttpGet]
			[Route("{id}")]
			public HttpResponseMessage id(int id)
			{
				try
				{
					ViewCancellationService obj = new ViewCancellationService();
					var items = obj.GetBookReport(id);
					List<TicketCancellation> dtos = new List<TicketCancellation>();
					//foreach (var item in items)
					//{
					//    dtos.Add(new BookTicketDtos { Match_Id = item.Match_Id, Location = item.Location, Number_Of_Seats = item.Number_Of_Seats });
					//}
					if (items == null)
						return Request.CreateResponse(HttpStatusCode.NotFound, dtos);
					return Request.CreateResponse(HttpStatusCode.OK, items);

				}
				catch (DbException ex)
				{
					return Request.CreateResponse(HttpStatusCode.OK, ex);
				}
				catch (Exception ex)
				{
					return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
				}
			}

		}
	}

