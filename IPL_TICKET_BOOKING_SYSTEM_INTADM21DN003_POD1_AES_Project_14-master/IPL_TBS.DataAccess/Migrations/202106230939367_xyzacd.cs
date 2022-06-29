namespace IPL_TBS.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xyzacd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TicketCancellations",
                c => new
                    {
                        SNo = c.Int(nullable: false, identity: true),
                        Match_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                        Booking_Id = c.Int(nullable: false),
                        Location = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SNo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TicketCancellations");
        }
    }
}
