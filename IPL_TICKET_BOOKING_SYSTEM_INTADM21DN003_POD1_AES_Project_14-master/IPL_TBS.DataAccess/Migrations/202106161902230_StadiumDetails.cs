namespace IPL_TBS.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StadiumDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StadiumDetails",
                c => new
                    {
                        Match_Id = c.Int(nullable: false),
                        Location = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Capacity = c.String(nullable: false),
                        Home_To = c.String(nullable: false),
                        Ends = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Match_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StadiumDetails");
        }
    }
}
