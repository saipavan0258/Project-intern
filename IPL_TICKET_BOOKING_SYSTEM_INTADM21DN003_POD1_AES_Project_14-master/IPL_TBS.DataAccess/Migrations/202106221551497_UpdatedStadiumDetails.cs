namespace IPL_TBS.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedStadiumDetails : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.StadiumDetails");
            AlterColumn("dbo.StadiumDetails", "Match_Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.StadiumDetails", "Match_Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.StadiumDetails");
            AlterColumn("dbo.StadiumDetails", "Match_Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.StadiumDetails", "Match_Id");
        }
    }
}
