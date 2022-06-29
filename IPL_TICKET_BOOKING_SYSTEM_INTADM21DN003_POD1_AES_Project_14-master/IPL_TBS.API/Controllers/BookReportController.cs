using IPL_TBS.API.Dtos;
using IPL_TBS.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IPL_TBS.API.Controllers
{
    public class BookReportController : ApiController
    {
		[RoutePrefix("api/ReportLocation")]
		public class Report_LocationController : ApiController
		{
			[HttpGet]
			[Route("{location}")]
			public HttpResponseMessage Location(string location)
			{
				try
				{
					BookReportService obj = new BookReportService();
					var items = obj.GetBookReport(location);
					List<BookReportDtos> dtos = new List<BookReportDtos>();
					//foreach (var item in items)
					//{
					// dtos.Add(new BookTicketDtos { Match_Id = item.Match_Id, Location = item.Location, Number_Of_Seats = item.Number_Of_Seats });
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
}
