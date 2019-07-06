using System.Collections.Generic;
using System.Windows.Controls;
using WaterPolo.Simple.Core.Display;

namespace WaterPolo.Simple.Core.Control
{
    /// <summary>
    ///     Interaction logic for MatchDisplayControl.xaml
    /// </summary>
    public partial class MatchDisplayControl : UserControl
    {
        public MatchDisplayControl()
        {
            InitializeComponent();

            //DataContext = Match;
        }

        #region Create Test Data

        private MatchModel Match;

        private void CreateTestData()
        {
            Match = new MatchModel();
            Match.TotalTime = "8:00";
            Match.Court = 1;
            Match.TeamA = new TeamModel
            {
                Name = "CHN",
                Score = 1
            };
            AddPlayer(Match.TeamA);
            Match.TeamB = new TeamModel
            {
                Name = "USA",
                Score = 0
            };
            AddPlayer(Match.TeamB);
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
                player.Fouls = 3;
                player.FoulTime = 20;
                players.Add(player);
            }

            team.Players = players;
        }

        #endregion
    }
}