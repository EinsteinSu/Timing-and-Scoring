using System.Drawing;
using System.Windows.Forms;
using ApplicationControlCommon;
using Common;
using log4net;
using Water_Polo.Properties;

namespace Water_Polo
{
    public partial class HomePage : SimpleApplicationForm
    {
        private static readonly ILog Log = LogManager.GetLogger("HomePage");

        public HomePage()
        {
            InitializeComponent();
            TitlePictureBox.Width = 100;
            TitleGroupBox.Height = 100;
            TitlePictureBox.Image = Resources.Emblem100_80;
            Log.Info("Hello");
            TitleLabel.Text = @"WATER-POLO MAJOR CONSOLE";
            TitleLabel.Font = new Font("宋体", 32, FontStyle.Bold);
            FunctionParent.BackgroundImage = Resources.Emblem;

            AddFunctionButton(12F, "Show Desktop", ContentAlignment.MiddleCenter, 0, null,
                ContentAlignment.MiddleCenter);
            AddFunctionButton(12F, "Settings", ContentAlignment.MiddleCenter, 1, null, ContentAlignment.MiddleCenter);
            AddFunctionButton(12F, "Loading Match", ContentAlignment.MiddleCenter, 2, null,
                ContentAlignment.MiddleCenter);
            AddFunctionButton(12F, "Process Data", ContentAlignment.MiddleCenter, 3, null,
                ContentAlignment.MiddleCenter);
            AddFunctionButton(12F, "Lock Window", ContentAlignment.MiddleCenter, 4, null,
                ContentAlignment.MiddleCenter);
            AddFunctionButton(12F, "Quit", ContentAlignment.MiddleCenter, 5, null, ContentAlignment.MiddleCenter);
        }

        private void HomePage_FunctionClick(string functionName)
        {
            switch (functionName)
            {
                case "Show Desktop":
                    FunctionParent.ShowDeskTop();
                    break;
                case "Settings":
                    ShowControl(typeof(SettingsControl), DockStyle.Fill);
                    break;
                case "Process Data":
                    ShowControl(typeof(ProcessData), DockStyle.Fill);
                    break;
                case "Lock Window":
                    FunctionParent.ShowDeskTop();
                    var frm = new LockWindow();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                    }
                    break;
                case "Loading Match":
                    ShowControl(typeof(LoadMatchControl), DockStyle.Fill);
                    break;
                case "Quit":
                    CloseApplication();
                    break;
            }
        }
    }
}