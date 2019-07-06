using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DevExpress.Mvvm;
using log4net;
using Newtonsoft.Json;
using WaterPolo.Simple.Core;
using WaterPolo.Simple.Core.Control;
using WaterPolo.Simple.Core.DataTransfer;
using WaterPolo.Simple.Core.DataTransfer.SerialDevice;
using WaterPolo.Simple.Core.Display;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.RefereeConsole
{
    public class MainWindowViewModel : ViewModelBase
    {
        private static readonly ILog Log = LogManager.GetLogger("Referee Console");
        private readonly WaterPoloDataContext _context = new WaterPoloDataContext();
        private MatchModel _match;
        private ScheduleSelectionViewModel _selectionViewModel;

        private Task _sendMessageTask;
        private bool _showMatchController;
        private bool _stop;

        private string _currentDialogWindow = "schedule";
        protected string RootPath = AppDomain.CurrentDomain.BaseDirectory;
        private SettingsRaw _settings;

        public MainWindowViewModel()
        {
            ShowMatchController = false;
            var dep = new DependencyObject();
            LoadConfigures();
            if (!DesignerProperties.GetIsInDesignMode(dep))
            {
                CreateTestData();
                //LoadSchedule(6);

                #region serial port devices
                if (_settings.TotalTimeDevicePort > 0)
                {
                    var totalTimeDevice = new TotalTimeController(_settings.TotalTimeDevicePort)
                    {
                        DisplayData = data =>
                        {
                            if (Match != null)
                            {
                                Match.TotalTime = data.Time;
                            }
                        }
                    };
                    try
                    {
                        totalTimeDevice.StartListening();
                    }
                    catch (Exception e)
                    {
                        Log.Error("The total time device cannot be found", e);
                    }
                }

                if (_settings.ThirtySecondsDevicePort > 0)
                {
                    var thirtySecondsDevice = new ThirtySecondsTimeController(_settings.ThirtySecondsDevicePort)
                    {
                        DisplayData = data =>
                        {
                            if (Match != null)
                            {
                                Match.ThirtySeconds = data.Seconds;
                            }
                        }
                    };
                    try
                    {
                        thirtySecondsDevice.StartListening();
                    }
                    catch (Exception e)
                    {
                        Log.Error("The thirty seconds time device cannot be found", e);
                    }
                }
                #endregion

            }
        }

        private IDialogService DialogService => GetService<IDialogService>(_currentDialogWindow);

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
                    _currentDialogWindow = "schedule";
                    LoadSchedule();
                    break;
                case Key.S:
                    _currentDialogWindow = "settings";
                    LoadSettings();
                    break;
            }
        }

        ~MainWindowViewModel()
        {
            _stop = true;

        }

        #region Settings

        private SettingsViewModel _settingsViewModel;

        private void LoadConfigures()
        {
            var rootFolder = Path.Combine(RootPath, "Data");
            _settings = SettingsHelper.LoadData<SettingsRaw>(rootFolder, "Configs.config") ?? SettingsRaw.InitialSettings();
        }

        protected void LoadSettings()
        {
            if (_settingsViewModel == null)
                _settingsViewModel = new SettingsViewModel();

            #region  Create Buttons

            var okCommand = new UICommand
            {
                Caption = "Ok",
                IsCancel = false,
                IsDefault = true,
                Command = new DelegateCommand<CancelEventArgs>(
                    x => { }, x => ValidateSettings())
            };
            var cancelCommand = new UICommand
            {
                Caption = "Close",
                IsCancel = true
            };

            #endregion

            var result = DialogService.ShowDialog(new List<UICommand> { okCommand, cancelCommand },
                "Settings", _settingsViewModel);
            if (result == okCommand)
            {
                _settingsViewModel.Save();
                LoadConfigures();
            }
        }

        private bool ValidateSettings()
        {
            return !string.IsNullOrEmpty(_settingsViewModel.Settings.DisplayConsoleSettings.IpAddress) &&
                   _settingsViewModel.Settings.DisplayConsoleSettings.Port > 0;
        }

        #endregion

        #region load schedule 

        protected void LoadSchedule()
        {
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
            if (result == okCommand) LoadSchedule(_selectionViewModel.SelectedSchedule.ScheduleId);
        }



        private void DecreaseTwentySeconds()
        {
            Match.TeamA?.DecreaseFoulTimes();
            Match.TeamB?.DecreaseFoulTimes();
        }
        private void LoadSchedule(int scheduleId)
        {
            Match = new MatchModel
            {
                TotalTime = "8:00",
                Court = 1,

            };
            if (_settings.TwentySecondsRelatedToTotalTime)
            {
                Match.TotalTimeChanged = DecreaseTwentySeconds;
            }
            else
            {
                Match.ThirtySecondsChanged = i => { DecreaseTwentySeconds(); };
            }
            var schedule = _context.Schedules.Include(i => i.TeamA).Include(i => i.TeamB)
                .Include(i => i.TeamA.Team)
                .Include(i => i.TeamB.Team)
                .Include(i => i.TeamA.Players)
                .Include(i => i.TeamB.Players)
                .FirstOrDefault(f => f.ScheduleId == scheduleId);
            if (schedule != null)
            {
                Match.TeamA = GetTeam(schedule.TeamA);
                Match.TeamB = GetTeam(schedule.TeamB);
            }

            if (_sendMessageTask == null && _settings.SendToDisplayConsole)
            {
                _sendMessageTask = new Task(() =>
                {
                    Log.Info("Sending message thread has started.");
                    while (true)
                    {
                        var data = JsonConvert.SerializeObject(TransferDataConvert.ConvertToMatchRaw(Match));
                        Log.Debug($"Send Message: {data}");
                        SocketHelper.SendMessage(_settings.IpAddress, _settings.Port, data, 50000);
                        Thread.Sleep(300);
                        if (_stop)
                        {
                            Log.Info("Sending message thread has stopped.");
                            break;
                        }
                    }
                });
                _sendMessageTask.Start(TaskScheduler.Current);
            }
        }

        #endregion

        #region get data from database

        private TeamModel GetTeam(TeamMatch teamMatch)
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
                if (_settings.AutoShowTwentySeconds)
                {
                    p.FoulsChanged = (oldValue, newValue) =>
                    {
                        if (oldValue < newValue)
                        {
                            p.FoulTime = 20;
                        }
                    };
                }
                players.Add(p);
            }

            return players;
        }

        #endregion

        #region create test data

        private void CreateTestData()
        {
            Match = new MatchModel();
            Match.TotalTime = "8:00";
            Match.Court = 1;
            Match.TeamA = new TeamModel
            {
                Name = "CHN",
                Score = 1,
                PauseTime = "0:59"
            };
            AddPlayer(Match.TeamA);
            Match.TeamB = new TeamModel
            {
                Name = "USA",
                Score = 0
            };
            AddPlayer(Match.TeamB);

            if (_sendMessageTask == null && _settings.SendToDisplayConsole)
            {
                _sendMessageTask = new Task(() =>
                {
                    Log.Info("Sending message thread has started.");
                    while (true)
                    {
                        var data = JsonConvert.SerializeObject(TransferDataConvert.ConvertToMatchRaw(Match));
                        Log.Debug($"Send Message: {data}");
                        SocketHelper.SendMessage("::1", 1234, data, 10000);
                        Thread.Sleep(300);
                        if (_stop)
                        {
                            Log.Info("Sending message thread has stopped.");
                            break;
                        }
                    }
                });
                _sendMessageTask.Start(TaskScheduler.Current);
            }
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
                if (_settings.AutoShowTwentySeconds)
                {
                    player.FoulsChanged = (oldValue, newValue) =>
                    {
                        if (oldValue < newValue)
                        {
                            player.FoulTime = 20;
                        }
                    };
                }

                players.Add(player);
            }

            team.Players = players;
        }

        #endregion
    }
}