namespace IPL_TBS.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xyzacd1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TicketCancellations", "Reason", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TicketCancellations", "Reason");
        }
    }
}
