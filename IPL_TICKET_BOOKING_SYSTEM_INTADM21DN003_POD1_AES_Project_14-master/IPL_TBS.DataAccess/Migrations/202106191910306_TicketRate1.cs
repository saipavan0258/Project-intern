namespace IPL_TBS.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TicketRate1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Registers", "Login_UserId", "dbo.Logins");
            DropIndex("dbo.Registers", new[] { "Login_UserId" });
            DropPrimaryKey("dbo.MatchDetails");
            AlterColumn("dbo.MatchDetails", "Match_Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.MatchDetails", "Match_Id");
            DropColumn("dbo.Registers", "Login_UserId");
            DropTable("dbo.Food_Beverages");
            DropTable("dbo.Logins");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Food_Beverages",
                c => new
                    {
                        Product_Id = c.Int(nullable: false, identity: true),
                        Product_Name = c.String(nullable: false),
                        Quantity = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Product_Id);
            
            AddColumn("dbo.Registers", "Login_UserId", c => c.Int());
            DropPrimaryKey("dbo.MatchDetails");
            AlterColumn("dbo.MatchDetails", "Match_Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.MatchDetails", "Match_Id");
            CreateIndex("dbo.Registers", "Login_UserId");
            AddForeignKey("dbo.Registers", "Login_UserId", "dbo.Logins", "UserId");
        }
    }
}
