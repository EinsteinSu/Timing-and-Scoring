namespace WaterPolo.Simple.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCaptionInMatch2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TeamMatches", "Player_PlayerId", "dbo.Players");
            DropIndex("dbo.TeamMatches", new[] { "Player_PlayerId" });
            DropColumn("dbo.TeamMatches", "Player_PlayerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TeamMatches", "Player_PlayerId", c => c.Int());
            CreateIndex("dbo.TeamMatches", "Player_PlayerId");
            AddForeignKey("dbo.TeamMatches", "Player_PlayerId", "dbo.Players", "PlayerId");
        }
    }
}
