namespace IPL_TBS.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IPLdb : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Registers");
            AlterColumn("dbo.Registers", "UserId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Registers", "UserId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Registers");
            AlterColumn("dbo.Registers", "UserId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Registers", "UserId");
        }
    }
}
