namespace IPL_TBS.DataAccess.Entities
{
	//using Microsoft.EntityFrameworkCore;
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class RegisterDBContext : DbContext
	{
		//private readonly AuthContext context;
		public RegisterDBContext()
			: base("name=RegisterDBContext")
		{
		}
		public virtual DbSet<Register> Registers { get; set; }

		public virtual DbSet<MatchDetails> MatchDetail { get; set; }

		public virtual DbSet<StadiumDetails> StadiumDetail { get; set; }

		public virtual DbSet<TicketRate> TicketRates { get; set; }

		public virtual DbSet<BookTicket> BookTickets { get; set; }

		public virtual DbSet<Food_Beverages> Food_Beverages { get; set; }

		public virtual DbSet<TicketBooking> TicketBookings { get; set; }
		public virtual DbSet <TicketCancellation> TicketCancellations { get; set; }
	}

}