using IPL_TBS.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPL_TBS.DataAccess;

namespace IPL_TBS.BusinessLogic
{
	public class MatchDetailsService : IDisposable
	{
		private readonly RegisterDBContext context;
		public MatchDetailsService()
		{
			context = new RegisterDBContext();
		}
		public void Dispose()
		{
			context.Dispose();
		}

		public void Post(string Location, string Date, string Battle)
		{
			try
			{
				MatchDetails obj1 = new MatchDetails();
				obj1.Location = Location;
				obj1.Date = Date;
				obj1.Battle = Battle;
				context.MatchDetail.Add(obj1);
			}
			catch (DbException ex)
			{
				throw new IPLException("Error Reading Data", ex);

			}
			catch (Exception ex)
			{
				throw new IPLException("Unknown Error while reading Stadiumdetails", ex);

			}
		}
		public List<MatchDetails> GetAllActive()
		{
			try
			{
				var items = from item in context.MatchDetail
								//where item.IsActive
							select item;
				return items.ToList();
			}
			catch (DbException ex)
			{
				throw new IPLException("Error reading data", ex);
			}
			catch (Exception ex)
			{
				throw new IPLException("Unknown error while reading Match Details", ex);
			}
		}
	}
}