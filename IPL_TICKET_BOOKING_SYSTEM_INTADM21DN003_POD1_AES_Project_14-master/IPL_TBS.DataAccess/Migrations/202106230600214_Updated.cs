namespace IPL_TBS.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updated : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Registers", new[] { "Email" });
            AlterColumn("dbo.Registers", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Registers", "Email", c => c.String(nullable: false, maxLength: 30));
            CreateIndex("dbo.Registers", "Email", unique: true);
        }
    }
}
