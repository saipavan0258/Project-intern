namespace IPL_TBS.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseNew : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Tickets");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Tickets",
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
    }
}
