namespace IPL_TBS.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MatchDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MatchDetails",
                c => new
                    {
                        Match_Id = c.Int(nullable: false),
                        Location = c.String(nullable: false),
                        Date = c.String(nullable: false),
                        Battle = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Match_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MatchDetails");
        }
    }
}
