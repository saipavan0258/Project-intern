using IPL_TBS.BusinessLogic;
using IPL_TBS.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic
{

	public class Food_BeveragesService : IDisposable
	{
		private readonly RegisterDBContext context;
		public Food_BeveragesService()
		{
			context = new RegisterDBContext();
		}
		public void Dispose()
		{
			context.Dispose();
		}

		public void Add_Food_Beverages(string Product_Name, int Quantity, int Price)
		{
			try
			{
				Food_Beverages obj1 = new Food_Beverages();
				obj1.Product_Name = Product_Name;
				obj1.Quantity = Quantity;
				obj1.Price = Price;
				context.Food_Beverages.Add(obj1);
			}
			catch (DbException ex)
			{
				throw new IPLException("Error Reading Data", ex);

			}
			catch (Exception ex)
			{
				throw new IPLException("Unknown Error while reading Fooddetails", ex);

			}
		}
	}
}
