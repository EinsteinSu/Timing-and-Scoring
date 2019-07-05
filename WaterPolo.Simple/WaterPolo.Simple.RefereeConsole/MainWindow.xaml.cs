using DevExpress.Xpf.Core;
using log4net.Config;

namespace WaterPolo.Simple.RefereeConsole
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            XmlConfigurator.Configure();
        }
    }
}