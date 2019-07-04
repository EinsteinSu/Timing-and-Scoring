using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraPrinting.Native.WebClientUIControl;
using Newtonsoft.Json;
using WaterPolo.Simple.Core.DataTransfer;
using WaterPolo.Simple.Core.Display;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.RefereeConsole
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly WaterPoloDataContext _context = new WaterPoloDataContext();
        private ScheduleSelectionViewModel _selectionViewModel;
        private MatchModel _match;
        private bool _showMatchController;

        public MainWindowViewModel()
        {
            ShowMatchController = false;
            var dep = new DependencyObject();
            if (!DesignerProperties.GetIsInDesignMode(dep))
            {
                LoadSchedule(6);

            }
        }

        private IDialogService DialogService => GetService<IDialogService>();

        public MatchModel Match
        {
            get => _match;
            set
            {
                SetProperty(ref _match, value, () => Match);
                ShowMatchController = Match != null;
            }
        }

        public bool ShowMatchController
        {
            get => _showMatchController;
            set => SetProperty(ref _showMatchController, value, () => ShowMatchController);
        }

        public void KeyDown(Key key)
        {
            switch (key)
            {
                case Key.L:
                    if (_selectionViewModel == null)
                        _selectionViewModel = new ScheduleSelectionViewModel(_context);

                    #region  Create Buttons
                    var okCommand = new UICommand
                    {
                        Caption = "Ok",
                        IsCancel = false,
                        IsDefault = true,
                        Command = new DelegateCommand<CancelEventArgs>(
                            x =>
                            {
                                //todo: load schedule by id
                            }, x => _selectionViewModel.SelectedSchedule != null)
                    };
                    var cancelCommand = new UICommand
                    {
                        Caption = "Close",
                        IsCancel = true
                    };
                    #endregion

                    var result = DialogService.ShowDialog(new List<UICommand> { okCommand, cancelCommand },
                        "Schedule Selection", _selectionViewModel);
                    if (result == okCommand)
                    {
                        LoadSchedule(_selectionViewModel.SelectedSchedule.ScheduleId);

                    }
                    break;
            }
        }

        private Task _sendMessageTask;
        private void LoadSchedule(int scheduleId)
        {
            Match = new MatchModel
            {
                TotalTime = "8:00",
                Court = 1
            };
            var schedule = _context.Schedules.Include(i => i.TeamA).Include(i => i.TeamB)
                .Include(i => i.TeamA.Team)
                .Include(i => i.TeamB.Team)
                .Include(i => i.TeamA.Players)
                .Include(i => i.TeamB.Players)
                .FirstOrDefault(f => f.ScheduleId == scheduleId);
            if (schedule != null)
            {
                Match.TeamA = GetTeamRaw(schedule.TeamA);
                Match.TeamB = GetTeamRaw(schedule.TeamB);
            }
            if (_sendMessageTask == null)
            {
                _sendMessageTask = new Task(() =>
                {
                    while (true)
                    {
                        var data = JsonConvert.SerializeObject(TransferDataConvert.ConvertToMatchRaw(Match));
                        SocketHelper.SendMessage("::1", 1234, data, 2048);
                        Thread.Sleep(300);
                        if (_stop)
                            break;
                    }

                });
                _sendMessageTask.Start(TaskScheduler.Current);
            }
        }

        private bool _stop;
        ~MainWindowViewModel()
        {
            _stop = true;
        }

        private TeamModel GetTeamRaw(TeamMatch teamMatch)
        {
            return new TeamModel
            {
                Name = teamMatch.Team.DisplayName,
                CapColor = teamMatch.CapColor.ToString(),
                Players = GetPlayer(teamMatch)
            };
        }

        private List<PlayerModel> GetPlayer(TeamMatch teamMatch)
        {
            var players = new List<PlayerModel>();
            foreach (var player in teamMatch.Players.OrderBy(o => o.OrderNumber))
            {
                var p = new PlayerModel
                {
                    Name = player.DisplayName,
                    Number = player.DisplayNumber
                };
                players.Add(p);
            }

            return players;
        }

        #region create test data
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
            var players = new System.Collections.Generic.List<PlayerModel>();
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

        public static MainWindowViewModel Create()
        {
            return ViewModelSource.Create(() => new MainWindowViewModel());
        }
    }
}