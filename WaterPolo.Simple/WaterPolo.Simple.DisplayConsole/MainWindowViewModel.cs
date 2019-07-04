using DevExpress.Mvvm.POCO;
using System.ComponentModel;
using System.Windows;
using WaterPolo.Simple.Core.Display;

namespace WaterPolo.Simple.DisplayConsole
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            DependencyObject dep = new DependencyObject();
            if (!DesignerProperties.GetIsInDesignMode(dep))
            {
                Match = new MatchRaw();
                Match.TotalTime = "8:00";
                Match.Court = 1;
                Match.TeamA = new TeamRaw()
                {
                    Name = "CHN",
                    Score = 1
                };
                AddPlayer(Match.TeamA);
                Match.TeamB = new TeamRaw()
                {
                    Name = "USA",
                    Score = 0
                };
                AddPlayer(Match.TeamB);
            }
        }

        private void AddPlayer(TeamRaw team)
        {
            int playerCount = 13;
            var players = new PlayerRaw[playerCount];
            for (int i = 0; i < playerCount; i++)
            {
                var player = new PlayerRaw();
                player.Number = $"{i + 1}";
                player.Name = $"{team.Name}:Num.{i + 1}";
                players[i] = player;
            }
            team.Players = players;
        }

        public static MainWindowViewModel Create()
        {
            return ViewModelSource.Create(() => new MainWindowViewModel());
        }

        public virtual MatchRaw Match { get; set; }
    }
}
