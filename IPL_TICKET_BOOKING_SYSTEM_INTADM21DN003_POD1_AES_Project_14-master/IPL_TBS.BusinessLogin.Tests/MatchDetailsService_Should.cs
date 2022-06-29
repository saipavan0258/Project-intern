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
	public class MatchDetailsService_Should
	{
		private MatchDetailsService service;
		[OneTimeSetUp]
		public void Init()
		{
			service = new MatchDetailsService();
		}
		[OneTimeTearDown]
		public void Cleanup()
		{
			service.Dispose();
		}
		[Test]
		public void Return_All_Details()
		{
			Mock<MatchDetails> obj = new Mock<MatchDetails>();
			var card = obj.Object;
			Assert.IsNotEmpty(card.Location);
			Assert.IsNotEmpty(card.Date);
			Assert.IsNotEmpty(card.Battle);
		}
	}
}
