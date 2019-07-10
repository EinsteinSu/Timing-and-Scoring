namespace WaterPolo.Simple.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCaptionInMatch6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TeamMatches", "CaptainPlayerId", "dbo.Players");
            DropForeignKey("dbo.Players", "TeamMatch_TeamMatchId", "dbo.TeamMatches");
            DropForeignKey("dbo.TeamMatches", "Player_PlayerId", "dbo.Players");
            DropIndex("dbo.Players", new[] { "TeamMatch_TeamMatchId" });
            DropIndex("dbo.TeamMatches", new[] { "CaptainPlayerId" });
            DropIndex("dbo.TeamMatches", new[] { "Player_PlayerId" });
            CreateTable(
                "dbo.TeamMatchPlayers",
                c => new
                    {
                        TeamMatch_TeamMatchId = c.Int(nullable: false),
                        Player_PlayerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TeamMatch_TeamMatchId, t.Player_PlayerId })
                .ForeignKey("dbo.TeamMatches", t => t.TeamMatch_TeamMatchId, cascadeDelete: true)
                .ForeignKey("dbo.Players", t => t.Player_PlayerId, cascadeDelete: true)
                .Index(t => t.TeamMatch_TeamMatchId)
                .Index(t => t.Player_PlayerId);
            
            DropColumn("dbo.Players", "TeamMatch_TeamMatchId");
            DropColumn("dbo.TeamMatches", "CaptainPlayerId");
            DropColumn("dbo.TeamMatches", "Player_PlayerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TeamMatches", "Player_PlayerId", c => c.Int());
            AddColumn("dbo.TeamMatches", "CaptainPlayerId", c => c.Int());
            AddColumn("dbo.Players", "TeamMatch_TeamMatchId", c => c.Int());
            DropForeignKey("dbo.TeamMatchPlayers", "Player_PlayerId", "dbo.Players");
            DropForeignKey("dbo.TeamMatchPlayers", "TeamMatch_TeamMatchId", "dbo.TeamMatches");
            DropIndex("dbo.TeamMatchPlayers", new[] { "Player_PlayerId" });
            DropIndex("dbo.TeamMatchPlayers", new[] { "TeamMatch_TeamMatchId" });
            DropTable("dbo.TeamMatchPlayers");
            CreateIndex("dbo.TeamMatches", "Player_PlayerId");
            CreateIndex("dbo.TeamMatches", "CaptainPlayerId");
            CreateIndex("dbo.Players", "TeamMatch_TeamMatchId");
            AddForeignKey("dbo.TeamMatches", "Player_PlayerId", "dbo.Players", "PlayerId");
            AddForeignKey("dbo.Players", "TeamMatch_TeamMatchId", "dbo.TeamMatches", "TeamMatchId");
            AddForeignKey("dbo.TeamMatches", "CaptainPlayerId", "dbo.Players", "PlayerId");
        }
    }
}
