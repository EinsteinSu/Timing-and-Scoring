using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApplicationService
{
    public partial class ToolsControl : UserControl
    {
        public ToolsControl()
        {
            InitializeComponent();
            try
            {
                gcRelease.DataSource = RemoteCommon.SystemRelease.ONRELEASE;
            }
            catch { }
        }

        public override string ToString()
        {
            return "工具";
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            RemoteCommon.SystemRelease.ONRELEASE = RemoteCommon.SystemRelease.ONRELEASE;
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            RemoteCommon.SystemRelease sr = lvRelease.GetFocusedRow() as RemoteCommon.SystemRelease;
            if (sr != null && MessageBox.Show("是否删除此版本？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RemoteCommon.SystemRelease.ONRELEASE.Remove(sr);
                lvRelease.RefreshData();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            RemoteCommon.SystemRelease ar = new RemoteCommon.SystemRelease();
            if (RemoteCommon.SystemRelease.ONRELEASE.Count > 0)
                ar.RELEASE = (double.Parse(RemoteCommon.SystemRelease.ONRELEASE[RemoteCommon.SystemRelease.ONRELEASE.Count - 1].RELEASE) + 0.1).ToString();
            else
                ar.RELEASE = "1.0";
            ar.FILENAME = "Update.exe";
            RemoteCommon.SystemRelease.ONRELEASE.Add(ar);
            lvRelease.RefreshData();
        }
    }
}
