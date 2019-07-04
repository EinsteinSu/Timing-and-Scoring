using System.Windows;
using System.ComponentModel;
using DevExpress.Mvvm.POCO;
using WaterPolo.Simple.Core.Display;
using System.Windows.Input;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;

namespace WaterPolo.Simple.RefereeConsole
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            DependencyObject dep = new DependencyObject();
            if (!DesignerProperties.GetIsInDesignMode(dep))
            {
                CreateTestData();
            }
        }

        IDialogService DialogService { get { return this.GetService<IDialogService>(); } }

        ScheduleSelectionViewModel selectionViewModel;
        public void KeyDown(Key key)
        {
            switch (key)
            {
                case Key.L:
                    if (selectionViewModel == null)
                        selectionViewModel = new ScheduleSelectionViewModel();
                    var okCommand = new UICommand
                    {
                        Caption = "Ok",
                        IsCancel = false,
                        IsDefault = true,
                        Command = new DelegateCommand<CancelEventArgs>(
                            x =>
                            {
                                //todo: load schedule by id
                            }, x => selectionViewModel.SelectedSchedule != null)
                    };
                    var cancelCommand = new UICommand
                    {
                        Caption = "Close",
                        IsCancel = true,
                    };
                    var result = DialogService.ShowDialog(new List<UICommand> { okCommand, cancelCommand }, "Schedule Selection", selectionViewModel);
                    if (result == okCommand)
                    {
                        MessageBox.Show(selectionViewModel.SelectedSchedule.Name);
                    }
                    break;
            }
        }

        private void LoadSchedule()
        {

        }

        private void CreateTestData()
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
