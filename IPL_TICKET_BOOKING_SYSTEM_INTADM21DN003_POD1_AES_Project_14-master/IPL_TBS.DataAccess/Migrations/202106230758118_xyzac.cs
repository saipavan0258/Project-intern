namespace IPL_TBS.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xyzac : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TicketBookings", "Feedback");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TicketBookings", "Feedback", c => c.String(nullable: false));
        }
    }
}
