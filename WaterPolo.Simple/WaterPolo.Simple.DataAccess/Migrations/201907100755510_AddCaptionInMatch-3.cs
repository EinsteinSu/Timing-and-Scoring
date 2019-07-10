namespace WaterPolo.Simple.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCaptionInMatch3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TeamMatches", "CaptainPlayerId", "dbo.Players");
            DropIndex("dbo.TeamMatches", new[] { "CaptainPlayerId" });
            DropColumn("dbo.TeamMatches", "CaptainPlayerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TeamMatches", "CaptainPlayerId", c => c.Int());
            CreateIndex("dbo.TeamMatches", "CaptainPlayerId");
            AddForeignKey("dbo.TeamMatches", "CaptainPlayerId", "dbo.Players", "PlayerId");
        }
    }
}
