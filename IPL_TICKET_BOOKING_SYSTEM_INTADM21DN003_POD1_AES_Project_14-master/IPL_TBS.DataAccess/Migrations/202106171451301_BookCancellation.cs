namespace IPL_TBS.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookCancellation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookingCancellations",
                c => new
                    {
                        Match_Id = c.Int(nullable: false),
                        Booking_Id = c.Int(nullable: false),
                        Location = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Match_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BookingCancellations");
        }
    }
}
