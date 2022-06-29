namespace IPL_TBS.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondary : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.MatchDetails");
            AlterColumn("dbo.MatchDetails", "Match_Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.MatchDetails", "Match_Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.MatchDetails");
            AlterColumn("dbo.MatchDetails", "Match_Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.MatchDetails", "Match_Id");
        }
    }
}
