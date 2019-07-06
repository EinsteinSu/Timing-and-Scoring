namespace WaterPolo.Simple.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayerId = c.Int(nullable: false, identity: true),
                        DisplayNumber = c.String(),
                        Name = c.String(maxLength: 50),
                        DisplayName = c.String(nullable: false, maxLength: 12),
                        TeamId = c.Int(nullable: false),
                        OrderNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlayerId)
                .ForeignKey("dbo.Teams", t => t.TeamId)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        DisplayName = c.String(nullable: false, maxLength: 4),
                        Flag = c.Binary(),
                    })
                .PrimaryKey(t => t.TeamId);
            
            CreateTable(
                "dbo.TeamMatches",
                c => new
                    {
                        TeamMatchId = c.Int(nullable: false, identity: true),
                        TeamId = c.Int(nullable: false),
                        CapColor = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeamMatchId)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        ScheduleId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 200),
                        DisplayName = c.String(maxLength: 50),
                        StartTime = c.DateTime(),
                        EndTime = c.DateTime(),
                        TeamA_TeamMatchId = c.Int(),
                        TeamB_TeamMatchId = c.Int(),
                    })
                .PrimaryKey(t => t.ScheduleId)
                .ForeignKey("dbo.TeamMatches", t => t.TeamA_TeamMatchId)
                .ForeignKey("dbo.TeamMatches", t => t.TeamB_TeamMatchId)
                .Index(t => t.TeamA_TeamMatchId)
                .Index(t => t.TeamB_TeamMatchId);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedules", "TeamB_TeamMatchId", "dbo.TeamMatches");
            DropForeignKey("dbo.Schedules", "TeamA_TeamMatchId", "dbo.TeamMatches");
            DropForeignKey("dbo.TeamMatches", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.TeamMatchPlayers", "Player_PlayerId", "dbo.Players");
            DropForeignKey("dbo.TeamMatchPlayers", "TeamMatch_TeamMatchId", "dbo.TeamMatches");
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropIndex("dbo.TeamMatchPlayers", new[] { "Player_PlayerId" });
            DropIndex("dbo.TeamMatchPlayers", new[] { "TeamMatch_TeamMatchId" });
            DropIndex("dbo.Schedules", new[] { "TeamB_TeamMatchId" });
            DropIndex("dbo.Schedules", new[] { "TeamA_TeamMatchId" });
            DropIndex("dbo.TeamMatches", new[] { "TeamId" });
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropTable("dbo.TeamMatchPlayers");
            DropTable("dbo.Schedules");
            DropTable("dbo.TeamMatches");
            DropTable("dbo.Teams");
            DropTable("dbo.Players");
        }
    }
}
