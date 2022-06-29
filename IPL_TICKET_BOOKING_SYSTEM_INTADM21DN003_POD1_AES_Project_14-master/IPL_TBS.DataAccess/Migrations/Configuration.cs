namespace IPL_TBS.DataAccess.Migrations
{
	using IPL_TBS.DataAccess.Entities;
	using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IPL_TBS.DataAccess.Entities.RegisterDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(IPL_TBS.DataAccess.Entities.RegisterDBContext context)
        {
		    var jojo = new Register { FirstName="Nive",LastName="aaaa",PhoneNumber="9999999999",Email = "jojo@gmail.com", Password = "Jojo@123" };
			context.Registers.AddOrUpdate(u => u.Email, jojo);

			

			var ticketrate = new TicketRate { Match_Id=12,Gold_Rate = 10000, Diamond_Rate = 100, Platinum_Rate = 1000, Gold_Count = 123, Diamond_Count = 234, Platinum_Count = 500 };
			context.TicketRates.AddOrUpdate(u => u.Gold_Rate,null);
		}
		
    }
}
