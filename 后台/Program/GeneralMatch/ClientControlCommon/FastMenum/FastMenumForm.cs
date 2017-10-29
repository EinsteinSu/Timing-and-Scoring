using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ClientControlCommon
{
    public partial class FastMenumForm : ApplicationControlCommon.DialogBaseForm
    {
        public FastMenumForm()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);  //  禁止擦除背景. 
            SetStyle(ControlStyles.DoubleBuffer, true);  //  双缓冲

            this.Location = new Point(5, Screen.GetWorkingArea(this).Height - this.Height - 42);
            this.Deactivate += new EventHandler(FastMenum_Deactivate);

            var f = from data in ClientCommon.Functions.ONFUNCTIONS
                    from fast in ClientControlCommon.FastMenum.ONFASTMENUM
                    where data.GUID == fast.FUNCTIONGUID && fast.USERGUID == ClientCommon.SystemUsers.ONUSERS.GUID
                    select data;
            int i = 1;
            foreach (ClientCommon.Functions fc in f)
            {
                foreach (Control ctrl in tableLayoutPanel1.Controls)
                {
                    FastmenumLabel flb = ctrl as FastmenumLabel;
                    if (flb != null && flb.Name == "fastmenumLabel" + i.ToString())
                    {
                        flb.Tag = fc;
                        flb.FunctionClick += new FastmenumLabel.FunctionClickCallback(flb_FunctionClick);
                        break;
                    }
                }
                i++;
            }
        }

        public delegate void FunctionClickCallback(ClientCommon.Functions f);
        public event FunctionClickCallback FunctionClick;
        void flb_FunctionClick(ClientCommon.Functions f)
        {
            if (FunctionClick != null)
                FunctionClick(f);
        }

        void FastMenum_Deactivate(object sender, EventArgs e)
        {
            this.Close();
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

    }
}
