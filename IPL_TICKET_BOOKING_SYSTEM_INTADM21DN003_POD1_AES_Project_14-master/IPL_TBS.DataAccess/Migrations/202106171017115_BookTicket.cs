namespace IPL_TBS.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookTicket : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookTickets",
                c => new
                    {
                        Match_Id = c.Int(nullable: false, identity: true),
                        Number_Of_Seats = c.Int(nullable: false),
                        Class_Type = c.String(),
                        Feedback = c.String(),
                    })
                .PrimaryKey(t => t.Match_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BookTickets");
        }
    }
}
