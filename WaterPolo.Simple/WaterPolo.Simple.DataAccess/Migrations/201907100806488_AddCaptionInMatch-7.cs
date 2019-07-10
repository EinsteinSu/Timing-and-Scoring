namespace WaterPolo.Simple.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCaptionInMatch7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TeamMatches", "CaptainPlayerId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TeamMatches", "CaptainPlayerId");
        }
    }
}
