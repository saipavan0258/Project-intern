using NUnit.Framework;
using System;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPL_TBS.BusinessLogic;
using IPL_TBS.DataAccess.Entities;
//using IPL_TBS.BusinessLogic;

namespace IPL_TBS.BusinessLogin.Tests
{
	[TestFixture]
	public class RegistrationService_Should
	{


		private RegistrationService service;
		[OneTimeSetUp]
		public void Init()
		{
			service = new RegistrationService();
		}
		[OneTimeTearDown]
		public void Cleanup()
		{
			service.Dispose();
		}
		[Test]
		public void Return_All_Details()
		{
			Mock<Register> obj = new Mock<Register>();
			var card = obj.Object;
			Assert.IsNotEmpty(card.FirstName);
			Assert.IsNotEmpty(card.LastName);
			Assert.IsNotEmpty(card.Password);
			Assert.IsNotEmpty(card.Email);
			Assert.IsNotEmpty(card.PhoneNumber);
		}

	}
}