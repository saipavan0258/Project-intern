using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using IPL_TBS.DataAccess.Entities;
using IPL_TBS.BusinessLogic;

namespace IPL_TBS.BusinessLogin.Tests
{
	[TestFixture]
	public class BookTicket_should
	{
		private BookTicketService service;
		[OneTimeSetUp]
		public void Init()
		{
			service = new BookTicketService();
		}
		[OneTimeTearDown]
		public void Cleanup()
		{
			service.Dispose();
		}
		[Test]
		public void Return_All_Details()
		{
			Mock<BookTicket> obj = new Mock<BookTicket>();
			var card = obj.Object;
			Assert.IsNotNull(card.Number_Of_Seats);
			Assert.IsNotEmpty(card.Class_Type);
			Assert.IsNotEmpty(card.Feedback);
			

		}
	}


}


