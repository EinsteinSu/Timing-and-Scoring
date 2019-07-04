using System;
using System.IO;
using System.Windows;
using WaterPolo.Simple.Core;

namespace WaterPolo.Simple.DisplayConsole
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected string RootPath = AppDomain.CurrentDomain.BaseDirectory;

        public MainWindow()
        {
            InitializeComponent();
            var rootFolder = Path.Combine(RootPath, "Data");
            var settigns = SettingsHelper.LoadData<DisplaySettings>(rootFolder, "settings.config") ??
                           new DisplaySettings
                           {
                               X = 0,
                               Y = 0,
                               Width = 1024,
                               Height = 768,
                               ListeningPort = 1234
                           };
            Top = settigns.Y;
            Left = settigns.X;
            Width = settigns.Width;
            Height = settigns.Height;
        }
    }
}