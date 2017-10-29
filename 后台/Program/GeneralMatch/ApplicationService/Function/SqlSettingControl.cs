using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RemoteCommon;

namespace ApplicationService
{
    public partial class SqlSettingControl : UserControl
    {
        public SqlSettingControl()
        {
            InitializeComponent();
            try
            {
                rbType.DataBindings.Add("EditValue", SqlConnect.ONSQLCONNECT, "CONNECTTYPE", true, DataSourceUpdateMode.OnPropertyChanged);
                tbIP.DataBindings.Add("Text", SqlConnect.ONSQLCONNECT, "IPADDRESS", true, DataSourceUpdateMode.OnPropertyChanged);
                tbDatabase.DataBindings.Add("Text", SqlConnect.ONSQLCONNECT, "DATABASENAME", true, DataSourceUpdateMode.OnPropertyChanged);
                tbUserName.DataBindings.Add("Text", SqlConnect.ONSQLCONNECT, "USERNAME", true, DataSourceUpdateMode.OnPropertyChanged);
                tbPassWord.DataBindings.Add("Text", SqlConnect.ONSQLCONNECT, "PASSWORD", true, DataSourceUpdateMode.OnPropertyChanged);
                cbPort.DataBindings.Add("Checked", SqlConnect.ONSQLCONNECT, "ISPORT", true, DataSourceUpdateMode.OnPropertyChanged);
                tbPort.DataBindings.Add("Text", SqlConnect.ONSQLCONNECT, "PORT", true, DataSourceUpdateMode.OnPropertyChanged);
                
                cbPort_CheckedChanged(null, null);
            }
            catch { }
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnect.ONSQLCONNECT = SqlConnect.ONSQLCONNECT;
                MessageBox.Show("设置成功！");
            }
            catch
            {
                MessageBox.Show("设置失败！");
            }
        }

        private void rbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbConnect.Enabled = (bool)rbType.EditValue;
        }

        private void cbPort_CheckedChanged(object sender, EventArgs e)
        {
            tbPort.Enabled = cbPort.Checked;
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            RemoteCommon.SqlManager sm = new SqlManager();
            try
            {
                 DataTable dt = sm.GetDataTable("select * from sysfiles");
                 if (dt != null && dt.Rows.Count > 0)
                     MessageBox.Show("数据库连接成功！");
                 else
                     MessageBox.Show("数据库连接失败！");

            }
            catch
            {
                MessageBox.Show("数据库连接失败！");
            }
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            RemoteCommon.SqlManager sm = new SqlManager();
            try
            {
                DataTable dt = sm.GetDataTable(rtbSql.Text);
                if (dt != null)
                    gcResult.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询错误！" + ex.Message);
                gcResult.DataSource = null;
            }
            finally
            {
                sm.Dispose();
            }
        }
    }
}
