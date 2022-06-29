using IPL_TBS.DataAccess.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPL_TBS.BusinessLogic;
using Moq;

namespace IPL_TBS.BusinessLogin.Tests
{


	[TestFixture]
	public class StadiumDetailsService_Should
	{
		private StadiumDetailsService service;
		[OneTimeSetUp]
		public void Init()
		{
			service = new StadiumDetailsService();
		}
		[OneTimeTearDown]
		public void Cleanup()
		{
			service.Dispose();
		}
		[Test]
		public void Return_All_Details()
		{
			Mock<StadiumDetails> obj = new Mock<StadiumDetails>();
			var card = obj.Object;
			Assert.IsNotEmpty(card.Name);
			Assert.IsNotEmpty(card.Location);
			Assert.IsNotEmpty(card.Capacity);
			Assert.IsNotEmpty(card.Home_To);
			Assert.IsNotEmpty(card.Ends);

		}
	}
}
