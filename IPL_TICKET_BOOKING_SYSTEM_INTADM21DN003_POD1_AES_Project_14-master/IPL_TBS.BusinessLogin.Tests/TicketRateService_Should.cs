using NUnit.Framework;
using System;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPL_TBS.BusinessLogic;
using IPL_TBS.DataAccess.Entities;

namespace IPL_TBS.BusinessLogin.Tests
{
	[TestFixture]
	public class TicketRateService_Should
	{


		private TicketRateService service;
		[OneTimeSetUp]
		public void Init()
		{
			service = new TicketRateService();
		}
		[OneTimeTearDown]
		public void Cleanup()
		{
			service.Dispose();
		}
		[Test]
		public void Return_All_Details()
		{
			Mock<TicketRate> obj = new Mock<TicketRate>();
			var card = obj.Object;
			Assert.IsNotNull(card.Gold_Rate);
			Assert.IsNotNull(card.Diamond_Rate);
			Assert.IsNotNull(card.Platinum_Rate);
			Assert.IsNotNull(card.Gold_Count);
			Assert.IsNotNull(card.Diamond_Count);
			Assert.IsNotNull(card.Platinum_Count);
		}

	}
}