namespace IPL_TBS.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xyza : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TicketBookings",
                c => new
                    {
                        Booking_id = c.Int(nullable: false, identity: true),
                        Match_Id = c.Int(nullable: false),
                        user_Id = c.Int(nullable: false),
                        Location = c.String(nullable: false),
                        Number_Of_Seats = c.Int(nullable: false),
                        Class_Type = c.String(nullable: false),
                        Feedback = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Booking_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TicketBookings");
        }
    }
}
