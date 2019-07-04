using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WaterPolo.Simple.DataAccess.Test
{
    [TestClass]
    public class DataInputTest
    {
        protected readonly WaterPoloDataContext Context = new WaterPoloDataContext();

        [TestMethod]
        public void CreateTeam()
        {
            var id = CreateTeam("Team1");
            Assert.IsTrue(id > 0);
        }

        [TestCleanup]
        public void Clean()
        {
            Context.Database.ExecuteSqlCommand("Delete from schedules");
            Context.Database.ExecuteSqlCommand("Delete from teammatches");
            Context.Database.ExecuteSqlCommand("Delete from players");
            Context.Database.ExecuteSqlCommand("Delete from teams");
        }

        [TestMethod]
        public void CreatePlayer()
        {
            var teamId = CreateTeam("Team1");
            var id = CreatePlayer("Player1", teamId);
            Assert.IsTrue(id > 0);
        }

        [TestMethod]
        public void CreateSchedule()
        {
            var t1 = CreateTeam("team1");
            var t2 = CreateTeam("team2");
            var t1a = CreatePlayer("team1-a", t1);
            var t1b = CreatePlayer("team1-b", t1);
            var t2a = CreatePlayer("team2-a", t2);
            var t2b = CreatePlayer("team2-b", t2);
            var schedule = new Schedule();
            schedule.Name = schedule.DisplayName = "match 1";
            schedule.TeamA = new TeamMatch
            {
                CapColor = CapColor.White,
                TeamId = t1,
                Players = new List<Player>
                {
                    Context.Players.Find(t1a),
                    Context.Players.Find(t1b)
                }
            };
            schedule.TeamB = new TeamMatch
            {
                CapColor = CapColor.White,
                TeamId = t2,
                Players = new List<Player>
                {
                    Context.Players.Find(t2a),
                    Context.Players.Find(t2b)
                }
            };
            Context.Schedules.Add(schedule);
            Context.SaveChanges();
            Assert.IsTrue(schedule.ScheduleId > 0);
            Assert.IsTrue(schedule.TeamA.Players[0].Name == "team1-a");
            Assert.IsTrue(schedule.TeamB.Players[1].Name == "team2-b");
        }

        [TestMethod]
        public void CreateTeamPlayers()
        {
            var teamId = CreateTeam("Team1");
            CreatePlayer("Player1", teamId);
            CreatePlayer("Player1", teamId);
            var team = Context.Teams.Find(teamId);
            Assert.IsNotNull(team);
            Assert.IsTrue(team.Players.Count == 2);
        }

        private int CreatePlayer(string name, int teamId)
        {
            var player = new Player();
            player.Name = player.DisplayName = name;
            player.TeamId = teamId;
            Context.Players.Add(player);
            Context.SaveChanges();
            return player.PlayerId;
        }


        private int CreateTeam(string name)
        {
            var team = new Team();
            team.Name = name;
            team.DisplayName = "CHN";
            Context.Teams.Add(team);
            Context.SaveChanges();
            return team.TeamId;
        }
    }
}