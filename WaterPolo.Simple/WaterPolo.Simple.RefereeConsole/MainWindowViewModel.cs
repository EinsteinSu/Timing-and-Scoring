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
using WaterPolo.Simple.Core.Display.RawData;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.RefereeConsole
{
    public class MainWindowViewModel : ViewModelBase
    {
        private static readonly ILog Log = LogManager.GetLogger("Referee Console");
        private WaterPoloDataContext _context = new WaterPoloDataContext();

        private string _currentDialogWindow = "schedule";
        private MatchModel _match;
        private ScheduleSelectionViewModel _selectionViewModel;

        private Task _sendMessageTask;
        private SettingsRaw _settings;
        private bool _showMatchController;
        private bool _stop;
        private ThirtySecondsTimeController _thirtySecondsDevice;
        private TotalTimeController _totalTimeDevice;
        protected string RootPath = AppDomain.CurrentDomain.BaseDirectory;

        public MainWindowViewModel()
        {
            ShowMatchController = false;
            var dep = new DependencyObject();
            LoadConfigures();
            if (!DesignerProperties.GetIsInDesignMode(dep))
            {
                if (_settings.DebugMode)
                    CreateTestData();
                //LoadSchedule(6);

                #region serial port devices

                InitializeTotalTimeDevice();
                InitializeThirtySecondsDevice();

                #endregion
            }
        }

        private IDialogService DialogService => GetService<IDialogService>(_currentDialogWindow);
        private IOpenFileDialogService OpenFileDialogService => GetService<IOpenFileDialogService>();

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

        private void InitializeThirtySecondsDevice()
        {
            if (_settings.ThirtySecondsDevicePort > 0)
            {
                _thirtySecondsDevice?.EndListening();
                _thirtySecondsDevice = new ThirtySecondsTimeController(_settings.ThirtySecondsDevicePort)
                {
                    DisplayData = data =>
                    {
                        if (Match != null) Match.ThirtySeconds = data.Seconds;
                    }
                };
                try
                {
                    _thirtySecondsDevice.StartListening();
                }
                catch (Exception e)
                {
                    Log.Error("The thirty seconds time device cannot be found", e);
                }
            }
        }

        private void InitializeTotalTimeDevice()
        {
            if (_settings.TotalTimeDevicePort > 0)
            {
                _totalTimeDevice?.EndListening();
                _totalTimeDevice = new TotalTimeController(_settings.TotalTimeDevicePort)
                {
                    DisplayData = data =>
                    {
                        if (Match != null) Match.TotalTime = data.Time;
                    }
                };
                try
                {
                    _totalTimeDevice.StartListening();
                }
                catch (Exception e)
                {
                    Log.Error("The total time device cannot be found", e);
                }
            }
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
                case Key.D:
                    if (Match != null) Match.TotalTime = string.Empty;
                    break;
                case Key.R:
                    _currentDialogWindow = "reset";
                    Reset();
                    break;
                case Key.B:
                    Backup();
                    break;
                case Key.E:
                    Restore();
                    break;
            }
        }

        private void Restore()
        {
            OpenFileDialogService.Filter = "Backup Files (.bak)|*.bak|All Files (*.*)|*.*";
            OpenFileDialogService.FilterIndex = 1;
            var dialogResult = OpenFileDialogService.ShowDialog();
            if (dialogResult)
            {
                var data = JsonConvert.DeserializeObject<MatchRaw>(
                    File.ReadAllText(OpenFileDialogService.GetFullFileName()));
                if (data != null)
                {
                    Match = TransferDataConvert.ConvertToMatchModel(data);
                }
            }
        }

        private void Backup()
        {
            if (Match != null)
            {
                var rootFolder = Path.Combine(RootPath, "Data");
                File.WriteAllText(Path.Combine(rootFolder, "Backup.bak"), ConvertMatchToString());
            }
        }

        ~MainWindowViewModel()
        {
            _stop = true;
        }

        private void SetTeamTimeoutControl(TeamModel team)
        {
            if (_settings.AutoIncreasePauseCount)
                team.TimingControl.Started = () =>
                {
                    if (team.Timeout < 2)
                        team.Timeout++;
                };
        }

        #region Resets

        private void Reset()
        {
            var settings = new ResetSettings();

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
                    }, true)
            };
            var cancelCommand = new UICommand
            {
                Caption = "Close",
                IsCancel = true
            };

            #endregion

            var result = DialogService.ShowDialog(new List<UICommand> { okCommand, cancelCommand },
                "Reset", settings);
            if (result == okCommand)
            {
                if (settings.ResetTotalTimeDevice)
                    InitializeTotalTimeDevice();
                if (settings.ResetThirtySecondsDevice)
                    InitializeThirtySecondsDevice();
                if (settings.ResetDataContext)
                    _context = new WaterPoloDataContext();
                if (settings.ResetSending)
                {
                    _stop = true;
                    Thread.Sleep(1000);
                    StartSendMessage();
                }
            }
        }

        #endregion


        #region Settings

        private SettingsViewModel _settingsViewModel;

        private void LoadConfigures()
        {
            var rootFolder = Path.Combine(RootPath, "Data");
            _settings = SettingsHelper.LoadData<SettingsRaw>(rootFolder, "Configs.config") ??
                        SettingsRaw.InitialSettings();
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
                Court = 1
            };
            if (_settings.TwentySecondsRelatedToTotalTime)
                Match.TotalTimeChanged = DecreaseTwentySeconds;
            else
                Match.ThirtySecondsChanged = i => { DecreaseTwentySeconds(); };
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

            SetTeamTimeoutControl(Match.TeamA);
            SetTeamTimeoutControl(Match.TeamB);
            if (_sendMessageTask == null && _settings.SendToDisplayConsole) StartSendMessage();
        }

        private void StartSendMessage()
        {
            _sendMessageTask = new Task(() =>
            {
                Log.Info("Sending message thread has started.");
                Log.Info($"Sending message interval is {_settings.SendMessageInterval}");
                _stop = false;
                while (true)
                {
                    if (Match != null)
                    {
                        var data = ConvertMatchToString();
                        if (data.Length < 1024)
                        {
                            Log.Error(data);
                        }
                        Log.Debug($"Send Message: {data}");
                        SocketHelper.SendMessage(_settings.IpAddress, _settings.Port, data);
                    }

                    Thread.Sleep(_settings.SendMessageInterval);
                    if (_stop)
                    {
                        Log.Info("Sending message thread has stopped.");
                        break;
                    }
                }
            });
            _sendMessageTask.Start(TaskScheduler.Current);
        }

        private string ConvertMatchToString()
        {
            return JsonConvert.SerializeObject(TransferDataConvert.ConvertToMatchRaw(Match));
        }

        #endregion

        #region get data from database

        private TeamModel GetTeam(TeamMatch teamMatch)
        {
            var team = new TeamModel
            {
                Name = teamMatch.Team.DisplayName,
                CapColor = teamMatch.CapColor.ToString(),
                Players = GetPlayer(teamMatch)
            };
            if (_settings.ScoreRelatedGoals)
                team.RegisterGoalsChanged();
            if (_settings.AutoShowTwentySeconds)
                team.RegisterTwentySeconds();
            return team;
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

        #endregion

        #region create test data

        private void CreateTestData()
        {
            Match = new MatchModel();
            Match.TotalTime = "8:00";
            Match.Court = 1;
            Match.ThirtySeconds = 29;
            Match.TeamA = new TeamModel
            {
                Name = "CHN",
                Score = 1,
                PauseTime = "0:59"
            };
            SetTeamTimeoutControl(Match.TeamA);
            AddPlayer(Match.TeamA);
            Match.TeamB = new TeamModel
            {
                Name = "USA",
                Score = 0
            };
            SetTeamTimeoutControl(Match.TeamB);
            AddPlayer(Match.TeamB);

            if (_sendMessageTask == null && _settings.SendToDisplayConsole) StartSendMessage();
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
            if (_settings.AutoShowTwentySeconds)
                team.RegisterTwentySeconds();
            if (_settings.ScoreRelatedGoals)
                team.RegisterGoalsChanged();
        }

        #endregion
    }
}