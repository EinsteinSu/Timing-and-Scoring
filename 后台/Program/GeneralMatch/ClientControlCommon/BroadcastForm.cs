using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ClientControlCommon
{
    public partial class BroadcastForm : ApplicationControlCommon.DialogBaseForm
    {
        public BroadcastForm()
        {
            InitializeComponent();

            string fileName = string.Format(@"{0}\{1}.log", ApplicationCommon.DirectoryHelper.BroadCastDirectory, DateTime.Now.ToString("yyyy_MM_dd"));
            if (File.Exists(fileName))
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string str = "";
                    while (str != null)
                    {
                        str = sr.ReadLine();
                        if (str != null)
                            richTextBox1.AppendText(str + "\r\n");
                    }
                }
            }

            foreach (string str in Directory.GetFiles(ApplicationCommon.DirectoryHelper.BroadCastDirectory))
            {
                cbHistory.Items.Add(Path.GetFileName(str));
            }

            this.Location = new Point(Screen.GetWorkingArea(this).Width - this.Width, Screen.GetWorkingArea(this).Height - this.Height - 42);
            this.Deactivate += new EventHandler(BroadcastForm_Deactivate);
        }

        void BroadcastForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileName = string.Format(@"{0}\{1}", ApplicationCommon.DirectoryHelper.BroadCastDirectory, cbHistory.SelectedItem.ToString());
            richTextBox1.Clear();
            if (File.Exists(fileName))
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string str = "";
                    while (str != null)
                    {
                        str = sr.ReadLine();
                        if (str != null)
                            richTextBox1.AppendText(str + "\r\n");
                    }
                }
            }
        }
    }
}
