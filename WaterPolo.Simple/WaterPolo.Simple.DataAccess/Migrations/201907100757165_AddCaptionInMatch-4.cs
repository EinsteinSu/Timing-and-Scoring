namespace WaterPolo.Simple.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCaptionInMatch4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Players", "TeamMatch_TeamMatchId", "dbo.TeamMatches");
            DropIndex("dbo.Players", new[] { "TeamMatch_TeamMatchId" });
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
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "TeamMatch_TeamMatchId", c => c.Int());
            DropForeignKey("dbo.TeamMatchPlayers", "Player_PlayerId", "dbo.Players");
            DropForeignKey("dbo.TeamMatchPlayers", "TeamMatch_TeamMatchId", "dbo.TeamMatches");
            DropIndex("dbo.TeamMatchPlayers", new[] { "Player_PlayerId" });
            DropIndex("dbo.TeamMatchPlayers", new[] { "TeamMatch_TeamMatchId" });
            DropTable("dbo.TeamMatchPlayers");
            CreateIndex("dbo.Players", "TeamMatch_TeamMatchId");
            AddForeignKey("dbo.Players", "TeamMatch_TeamMatchId", "dbo.TeamMatches", "TeamMatchId");
        }
    }
}
