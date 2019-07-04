using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Newtonsoft.Json;
using WaterPolo.Simple.Core;
using WaterPolo.Simple.Core.DataTransfer;
using WaterPolo.Simple.Core.DataTransfer.Interface;
using WaterPolo.Simple.Core.Display;
using WaterPolo.Simple.Core.Display.RawData;

namespace WaterPolo.Simple.DisplayConsole
{
    public class MainWindowViewModel : ViewModelBase
    {
        private MatchModel _match;
        private SocketController controller;
        public MainWindowViewModel()
        {
            var dep = new DependencyObject();
            if (!DesignerProperties.GetIsInDesignMode(dep))
            {
                CreateTestData();
            }
            //LoadCommand = new DelegateCommand(Load, true);
        }

        protected string RootPath = System.AppDomain.CurrentDomain.BaseDirectory;
        private DisplaySettings _settigns;

        public DelegateCommand LoadCommand { get; set; }

        public void Load()
        {
            string rootFolder = Path.Combine(RootPath, "Data");
            Settigns = SettingsHelper.LoadData<DisplaySettings>(rootFolder, "settings.config") ?? new DisplaySettings
            {
                X = 0,
                Y = 0,
                Width = 1024,
                Height = 768,
                ListeningPort = 1234,
                Compacity = 2048
            };
            controller = new SocketController(Settigns.Compacity);
            controller.StartListening(new DataProcess((message) =>
            {
                //todo: save settings, display data
                var data = JsonConvert.DeserializeObject<MatchRaw>(message);
                if (data != null)
                {
                    Match = TransferDataConvert.ConvertToMatchModel(data);
                    Match.TotalTime = "sss";
                    RaisePropertiesChanged("Match");
                }
            }), Settigns.ListeningPort);
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
                    //todo： log it

                }
            }
        }

        ~MainWindowViewModel()
        {
            controller?.StopListening();
        }

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
                players.Add(player);
            }

            team.Players = players;
        }
        #endregion

    }
}