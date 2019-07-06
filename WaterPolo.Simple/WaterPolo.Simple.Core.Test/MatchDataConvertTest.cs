using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using WaterPolo.Simple.Core.Control;
using WaterPolo.Simple.Core.Display;

namespace WaterPolo.Simple.Core.Test
{
    [TestClass]
    public class MatchDataConvertTest
    {
        [TestMethod]
        public void Convert()
        {
            var match = CreateTestData();
            var data = JsonConvert.SerializeObject(TransferDataConvert.ConvertToMatchRaw(match));
            Console.WriteLine(data);
        }

        internal class TestData
        {
            public string Name { get; set; }
            public string Id { get; set; }
        }

        #region create test data

        private MatchModel CreateTestData()
        {
            var match = new MatchModel();
            match.TotalTime = "8:00";
            match.Court = 1;
            match.TeamA = new TeamModel
            {
                Name = "CHN",
                Score = 1
            };
            AddPlayer(match.TeamA);
            match.TeamB = new TeamModel
            {
                Name = "USA",
                Score = 0
            };
            AddPlayer(match.TeamB);
            return match;
        }

        private void AddPlayer(TeamModel team)
        {
            var playerCount = 13;
            var players = new List<PlayerModel>();
            for (var i = 0; i < playerCount; i++)
            {
                var player = new PlayerModel();
                player.Number = $"{i + 1}";
                player.Name = $"{team.Name}:Num.{i + 1}";
                players.Add(player);
            }

            team.Players = players;
        }

        #endregion
    }
}