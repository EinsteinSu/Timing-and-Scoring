namespace WaterPolo.Simple.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCaptionInMatch5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TeamMatchPlayers", "TeamMatch_TeamMatchId", "dbo.TeamMatches");
            DropForeignKey("dbo.TeamMatchPlayers", "Player_PlayerId", "dbo.Players");
            DropIndex("dbo.TeamMatchPlayers", new[] { "TeamMatch_TeamMatchId" });
            DropIndex("dbo.TeamMatchPlayers", new[] { "Player_PlayerId" });
            AddColumn("dbo.Players", "TeamMatch_TeamMatchId", c => c.Int());
            AddColumn("dbo.TeamMatches", "CaptainPlayerId", c => c.Int());
            AddColumn("dbo.TeamMatches", "Player_PlayerId", c => c.Int());
            CreateIndex("dbo.Players", "TeamMatch_TeamMatchId");
            CreateIndex("dbo.TeamMatches", "CaptainPlayerId");
            CreateIndex("dbo.TeamMatches", "Player_PlayerId");
            AddForeignKey("dbo.TeamMatches", "CaptainPlayerId", "dbo.Players", "PlayerId");
            AddForeignKey("dbo.Players", "TeamMatch_TeamMatchId", "dbo.TeamMatches", "TeamMatchId");
            AddForeignKey("dbo.TeamMatches", "Player_PlayerId", "dbo.Players", "PlayerId");
            DropTable("dbo.TeamMatchPlayers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TeamMatchPlayers",
                c => new
                    {
                        TeamMatch_TeamMatchId = c.Int(nullable: false),
                        Player_PlayerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TeamMatch_TeamMatchId, t.Player_PlayerId });
            
            DropForeignKey("dbo.TeamMatches", "Player_PlayerId", "dbo.Players");
            DropForeignKey("dbo.Players", "TeamMatch_TeamMatchId", "dbo.TeamMatches");
            DropForeignKey("dbo.TeamMatches", "CaptainPlayerId", "dbo.Players");
            DropIndex("dbo.TeamMatches", new[] { "Player_PlayerId" });
            DropIndex("dbo.TeamMatches", new[] { "CaptainPlayerId" });
            DropIndex("dbo.Players", new[] { "TeamMatch_TeamMatchId" });
            DropColumn("dbo.TeamMatches", "Player_PlayerId");
            DropColumn("dbo.TeamMatches", "CaptainPlayerId");
            DropColumn("dbo.Players", "TeamMatch_TeamMatchId");
            CreateIndex("dbo.TeamMatchPlayers", "Player_PlayerId");
            CreateIndex("dbo.TeamMatchPlayers", "TeamMatch_TeamMatchId");
            AddForeignKey("dbo.TeamMatchPlayers", "Player_PlayerId", "dbo.Players", "PlayerId", cascadeDelete: true);
            AddForeignKey("dbo.TeamMatchPlayers", "TeamMatch_TeamMatchId", "dbo.TeamMatches", "TeamMatchId", cascadeDelete: true);
        }
    }
}
