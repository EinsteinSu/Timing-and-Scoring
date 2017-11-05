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
            TitlePictureBox.Image = Resources.Emblem;
            TitlePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Log.Info("Hello");
            TitleLabel.Text = @"云南体拓科技有限公司 水球比赛中控平台（TTKJ-WP-SO-III）";
            TitleLabel.Font = new Font("宋体", 32, FontStyle.Bold);
            FunctionParent.BackgroundImage = Resources.Watchword;
            FunctionParent.BackgroundImageLayout = ImageLayout.Stretch;

            AddFunctionButton(12F, "显示桌面", ContentAlignment.MiddleCenter, 0, null,
                ContentAlignment.MiddleCenter);
            AddFunctionButton(12F, "设置", ContentAlignment.MiddleCenter, 1, null, ContentAlignment.MiddleCenter);
            AddFunctionButton(12F, "加载比赛", ContentAlignment.MiddleCenter, 2, null,
                ContentAlignment.MiddleCenter);
            AddFunctionButton(12F, "数据处理", ContentAlignment.MiddleCenter, 3, null,
                ContentAlignment.MiddleCenter);
            AddFunctionButton(12F, "锁定桌面", ContentAlignment.MiddleCenter, 4, null,
                ContentAlignment.MiddleCenter);
            AddFunctionButton(12F, "退出", ContentAlignment.MiddleCenter, 5, null, ContentAlignment.MiddleCenter);
        }

        private void HomePage_FunctionClick(string functionName)
        {
            switch (functionName)
            {
                case "显示桌面":
                    FunctionParent.ShowDeskTop();
                    break;
                case "设置":
                    ShowControl(typeof(SettingsControl), DockStyle.Fill);
                    break;
                case "数据处理":
                    ShowControl(typeof(ProcessData), DockStyle.Fill);
                    break;
                case "锁定桌面":
                    FunctionParent.ShowDeskTop();
                    var frm = new LockWindow();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                    }
                    break;
                case "加载比赛":
                    ShowControl(typeof(LoadMatchControl), DockStyle.Fill);
                    break;
                case "退出":
                    CloseApplication();
                    break;
            }
        }
    }
}