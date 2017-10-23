using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Common
{
    public partial class LockWindow : ApplicationControlCommon.DialogBaseForm
    {
        public LockWindow()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);  //  禁止擦除背景. 
            SetStyle(ControlStyles.DoubleBuffer, true);  //  双缓冲

            lueUser.DataBindings.Add("EditValue", ClientCommon.SystemUsers.ONUSERS, "GUID", true, DataSourceUpdateMode.OnPropertyChanged);
            lueUser.Properties.DataSource = new ClientCommon.SystemUsersPst(null).GetDataTable();
        }

        #region 画圆角
        public void SetWindowRegion()
        {
            System.Drawing.Drawing2D.GraphicsPath FormPath;
            FormPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);//this.Left-10,this.Top-10,this.Width-10,this.Height-10);                 
            FormPath = GetRoundedRectPath(rect, 30);
            this.Region = new Region(FormPath);
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();
            //   左上角   
            path.AddArc(arcRect, 180, 90);
            //   右上角   
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);
            //   右下角   
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);
            //   左下角   
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnResize(System.EventArgs e)
        {
            this.Region = null;
            SetWindowRegion();
        }
        #endregion

        private void btSetting_Click(object sender, EventArgs e)
        {
            DataRowView drv = lueUser.GetSelectedDataRow() as DataRowView;
            if (drv != null)
            {
                ApplicationCommon.PasswordHelper ph = new ApplicationCommon.PasswordHelper();
                if (drv["Password"].ToString() ==  ph.EncryptString(tbPassword.Text))
                {
                    ClientCommon.SystemUsers.ONUSERS = ClientCommon.SystemUsers.ONUSERS;
                    this.DialogResult = DialogResult.OK;
                }
                else
                    lbInfo.Text = "密码错误！";
            }
            else
                lbInfo.Text = "请选择一个用户！";
        }
    }
}
