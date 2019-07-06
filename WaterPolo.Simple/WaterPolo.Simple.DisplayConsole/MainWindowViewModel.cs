using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows.Input;
using DevExpress.Mvvm;
using log4net;
using Newtonsoft.Json;
using WaterPolo.Simple.Core;
using WaterPolo.Simple.Core.Control;
using WaterPolo.Simple.Core.DataTransfer;
using WaterPolo.Simple.Core.DataTransfer.Interface;
using WaterPolo.Simple.Core.Display.RawData;

namespace WaterPolo.Simple.DisplayConsole
{
    public class MainWindowViewModel : ViewModelBase
    {
        private static readonly ILog Log = LogManager.GetLogger("Display Console");
        private SocketController _controller;
        private MatchModel _match;
        private DisplaySettings _settigns;
        private string rootFolder;
        protected string RootPath = AppDomain.CurrentDomain.BaseDirectory;

        public MainWindowViewModel()
        {
            //if (!DesignerProperties.GetIsInDesignMode(dep))
            //{
                //CreateTestData();
            //}
            LoadCommand = new DelegateCommand(Load, true);
            //KeyDownCommand = new DelegateCommand(() => { MessageBox.Show("Key"); });
        }

        public DelegateCommand LoadCommand { get; set; }

        private IDialogService DialogService => GetService<IDialogService>();

        public DisplaySettings Settigns
        {
            get => _settigns;
            set => SetProperty(ref _settigns, value, () => Settigns);
        }

        public MatchModel Match
        {
            get => _match;
            set => SetProperty(ref _match, value, () => Match);
        }

        //public DelegateCommand KeyDownCommand { get; set; }

        public void KeyDown(Key key)
        {
            switch (key)
            {
                case Key.S:
                    LoadSettings();
                    break;
            }
        }


        protected void LoadSettings()
        {
            #region  Create Buttons

            var okCommand = new UICommand
            {
                Caption = "Ok",
                IsCancel = false,
                IsDefault = true,
                Command = new DelegateCommand<CancelEventArgs>(
                    x => { }, x => true)
            };
            var cancelCommand = new UICommand
            {
                Caption = "Close",
                IsCancel = true
            };

            #endregion

            var result = DialogService.ShowDialog(new List<UICommand> {okCommand, cancelCommand},
                "Settings", _settigns);

            if (result == okCommand) _settigns.SaveData(rootFolder, "Settings.config");
        }

        public void Load()
        {
            rootFolder = Path.Combine(RootPath, "Data");
            Settigns = SettingsHelper.LoadData<DisplaySettings>(rootFolder, "settings.config") ??
                       DisplaySettings.InitialDisplaySettings();
            _controller = new SocketController(Settigns.Campacity);
            _controller.StartListening(new DataProcess(message =>
            {
                Log.Debug(message);
                //todo: save settings, display data
                var data = JsonConvert.DeserializeObject<MatchRaw>(message);
                if (data != null) Match = TransferDataConvert.ConvertToMatchModel(data);
            }), Settigns.ListeningPort);
        }

        ~MainWindowViewModel()
        {
            Log?.Info("Stop listening.");
            _controller?.StopListening();
        }

        internal class DataProcess : IRequestProcess
        {
            private readonly Action<string> _acton;

            public DataProcess(Action<string> acton)
            {
                _acton = acton;
            }

            public void Process(TcpClient client, NetworkStream stream, byte[] bytesReceived)
            {
                try
                {
                    var message = Encoding.Unicode.GetString(bytesReceived, 0, bytesReceived.Length);
                    _acton?.Invoke(message);
                }
                catch (Exception e)
                {
                    Log.Error(e);
                }
            }
        }

        #region Create Test Data

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