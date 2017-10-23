using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Water_Polo
{
    public partial class HomePage : ApplicationControlCommon.SimpleApplicationForm
    {
        public HomePage()
        {
            InitializeComponent();
            TitlePictureBox.Width = 100;
            TitleGroupBox.Height = 100;
            TitlePictureBox.Image = Properties.Resources.Emblem100_80;
            TitleLabel.Text = "SHENZHEN 2011 UNIVERSIADE WATER-POLO MAJOR CONSOLE";
            TitleLabel.Font = new System.Drawing.Font("宋体", 32, FontStyle.Bold);
            FunctionParent.BackgroundImage = Properties.Resources.Emblem;

            AddFunctionButton(12F, "Show Desktop", ContentAlignment.MiddleCenter, 0, null, ContentAlignment.MiddleCenter);
            AddFunctionButton(12F, "Settings", ContentAlignment.MiddleCenter, 1, null, ContentAlignment.MiddleCenter);
            AddFunctionButton(12F, "Loading Match", ContentAlignment.MiddleCenter, 2, null, ContentAlignment.MiddleCenter);
            AddFunctionButton(12F, "Process Data", ContentAlignment.MiddleCenter, 3, null, ContentAlignment.MiddleCenter);
            AddFunctionButton(12F, "Lock Window", ContentAlignment.MiddleCenter, 4, null, ContentAlignment.MiddleCenter);
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
                    Common.LockWindow frm = new Common.LockWindow();
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
