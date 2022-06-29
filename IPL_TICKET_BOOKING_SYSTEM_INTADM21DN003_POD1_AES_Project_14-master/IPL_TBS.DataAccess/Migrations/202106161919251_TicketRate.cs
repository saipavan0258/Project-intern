namespace IPL_TBS.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TicketRate : DbMigration
    {
		public int Gold_Rate { get; internal set; }
		public int Diamond_Rate { get; internal set; }
		public int Platinum_Rate { get; internal set; }
		public int Gold_Count { get; internal set; }
		public int Diamond_Count { get; internal set; }
		public int Platinum_Count { get; internal set; }
		public int Match_Id { get; internal set; }

		public override void Up()
        {
            CreateTable(
                "dbo.TicketRates",
                c => new
                    {
                        Match_Id = c.Int(nullable: false, identity: true),
                        Gold_Rate = c.Int(nullable: false),
                        Diamond_Rate = c.Int(nullable: false),
                        Platinum_Rate = c.Int(nullable: false),
                        Gold_Count = c.Int(nullable: false),
                        Diamond_Count = c.Int(nullable: false),
                        Platinum_Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Match_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TicketRates");
        }
    }
}
