using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPL_TBS.BusinessLogic;
using IPL_TBS.DataAccess.Entities;
using Moq;
using Business_Logic;

namespace Business_login.test
{
	[TestFixture]
	public class Food_BeveragesService_Should
	{

		//private Food_BeveragesService service;
		private Food_BeveragesService service;
		[OneTimeSetUp]
		public void Init()
		{
			// service = new Food_BeveragesService();
			service = new Food_BeveragesService();
		}
		[OneTimeTearDown]
		public void Cleanup()
		{
			service.Dispose();
		}
		[Test]
		public void Return_All_Details()
		{
			Mock<Food_Beverages> obj = new Mock<Food_Beverages>();
			var card = obj.Object;
			Assert.IsNotEmpty(card.Product_Name);
			Assert.IsNotNull(card.Quantity);
			Assert.IsNotNull(card.Price);
		}
	}
}
