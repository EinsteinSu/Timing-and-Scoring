using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClientCommon;

namespace SystemManager
{
    public class SystemManagerMethod
    {
        public void ShowOption()
        {
            Options op = new Options();
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
            }
        }

        public void ShowPasswordChange()
        {
            PasswordChange pc = new PasswordChange();
            if (pc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { }
        }

        public void BackupDatabase()
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "*.bak|数据库备份文件*.bak";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                using (DevExpress.Utils.WaitDialogForm frm = new DevExpress.Utils.WaitDialogForm("请稍后", "正在下载备份数据 ..."))
                {
                    try
                    {
                        DatabaseBackupHelper.BackDatabase(sd.FileName);
                        //打开备份位置。
                        System.Diagnostics.Process.Start("Explorer", "/select," + sd.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("备份数据下载失败！");
                    }
                }
            }
        }

        public void ShowAbout()
        {
            AboutBox1 ab = new AboutBox1();
            if (ab.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}
