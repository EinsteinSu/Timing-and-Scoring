using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

        private Task _cleanTask;

        public MainWindowViewModel()
        {
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

            var result = DialogService.ShowDialog(new List<UICommand> { okCommand, cancelCommand },
                "Settings", _settigns);

            if (result == okCommand) _settigns.SaveData(rootFolder, "Settings.config");
        }

        public void Load()
        {
            Log.Info("Start loading.");
            try
            {
                rootFolder = Path.Combine(RootPath, "Data");
                Settigns = SettingsHelper.LoadData<DisplaySettings>(rootFolder, "settings.config") ??
                           DisplaySettings.InitialDisplaySettings();
                if (Settigns.DebugMode)
                    CreateTestData();
                _controller = new SocketController(Settigns.Campacity) { IpAddress = Settigns.ListeningAddress };
                _controller.StartListening(new DataProcess(message =>
                {
                    Log.Debug(message);
                    //todo: save settings, display data
                    var data = JsonConvert.DeserializeObject<MatchRaw>(message);
                    if (data != null) Match = TransferDataConvert.ConvertToMatchModel(data);
                }), Settigns.ListeningPort);
            }
            catch (Exception e)
            {
                Log.Error("Cannot open", e);
            }

            if (_cleanTask == null && _settigns.DnsFlushInterval > 0)
            {
                _cleanTask = new Task(() =>
                {
                    while (true)
                    {
                        if (_stop)
                            break;
                        Log.Info("Start cleaning the dns");
                        FlushCache();
                        GC.Collect();
                        Thread.Sleep(_settigns.DnsFlushInterval);
                    }
                });
                _cleanTask.Start();
            }
        }

        private bool _stop;

        [DllImport("dnsapi.dll", EntryPoint = "DnsFlushResolverCache")]
        private static extern UInt32 DnsFlushResolverCache();

        public static void FlushCache()
        {

            UInt32 result = DnsFlushResolverCache();
            Log.Info($"Cleaning cache result: {result}");
        }

        ~MainWindowViewModel()
        {
            Log.Info("Stop Cleaning cache thread.");
            _stop = true;
            Log?.Info("Stop listening.");
            _controller?.StopListening();
        }

        private class DataProcess : IRequestProcess
        {
            private readonly Action<string> _acton;
            private bool _quit;
            private Queue<string> queue;
            public DataProcess(Action<string> acton)
            {
                _acton = acton;
                queue = new Queue<string>();
                var processTask = new Task(ProcesMessage);
                processTask.Start();
            }

            void ProcesMessage()
            {

                while (true)
                {
                    if (_quit)
                        break;
                    if (queue.Count > 0)
                    {
                        var item = queue.Dequeue();
                        if (item != null)
                        {
                            try
                            {
                                _acton?.Invoke(item);
                            }
                            catch (Exception e)
                            {
                                Log.Error(e);
                            }
                        }
                    }
                    Thread.Sleep(100);
                }
            }

            public void Process(TcpClient client, NetworkStream stream, byte[] bytesReceived)
            {
                try
                {
                    var message = Encoding.Unicode.GetString(bytesReceived).Trim();
                    queue.Enqueue(message);
                    //_acton?.Invoke(message);
                }
                catch (Exception e)
                {
                    //Log.Error(Encoding.Unicode.GetString(bytesReceived));
                    //Log.Error(e);
                }
            }

            ~DataProcess()
            {
                _quit = true;
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
                Name = "MTG",
                Score = 12
            };
            AddPlayer(Match.TeamA);
            Match.TeamB = new TeamModel
            {
                Name = "CAN",
                Score = 9,
                PauseTime = "0:52"
            };
            AddPlayer(Match.TeamB);
        }

        private void AddPlayer(TeamModel team)
        {
            var playerCount = 14;
            var players = new List<PlayerModel>();
            for (var i = 0; i < playerCount; i++)
            {
                var player = new PlayerModel();
                player.Number = $"{i + 1}";
                player.Name = $"{team.Name}:Num.{i + 1}XXXXXXXXXX";
                player.Fouls = 3;
                player.FoulTime = 20;
                player.Goals = 1;
                players.Add(player);
            }

            team.Players = players;
        }

        #endregion
    }
}