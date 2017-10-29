using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientControlCommon
{
    public class FastmenumLabel : Label
    {
        public FastmenumLabel()
        {
            InitializeComponent();
            this.ContextMenuStrip = cms;
        }

        private ContextMenuStrip cms;
        private System.ComponentModel.IContainer components;
        private ToolStripMenuItem tsDelete;

        object _tag;
        new public object Tag
        {
            get
            {
                return _tag;
            }
            set
            {
                _tag = value;
                ClientCommon.Functions f = (ClientCommon.Functions)_tag;
                if (f == null)
                {
                    this.Visible = false;
                }
                else
                {
                    this.Visible = true;
                    this.Text = f.ToString();
                    this.Image = ClientCommon.SystemImages.GetImage(f.IMAGEINDEX);
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            this.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        }

        public delegate void FunctionClickCallback(ClientCommon.Functions f);
        public event FunctionClickCallback FunctionClick;
        protected override void OnClick(EventArgs e)
        {
            ClientCommon.Functions f = this.Tag as ClientCommon.Functions;
            if (f != null)
            {
                var c = from data in ClientCommon.SystemUsers.ONROLES
                        where f.GUID == data.FUNCTIONGUID
                        select data;
                if (c.Count() == 0)
                    MessageBox.Show("你无此权限！");
                else
                {
                    if (FunctionClick != null)
                        FunctionClick(f);
                }
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDelete});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(101, 26);
            // 
            // tsDelete
            // 
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(100, 22);
            this.tsDelete.Text = "删除";
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // FastmenumLabel
            // 
            this.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BackColor = System.Drawing.Color.Transparent;
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Size = new System.Drawing.Size(179, 90);
            this.Text = "Fast menum";
            this.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            ClientCommon.Functions f = this.Tag as ClientCommon.Functions;
            if (f != null)
                FastMenum.Delete(f.GUID);
            FastMenum.ONFASTMENUM = FastMenum.ONFASTMENUM;
            this.Tag = null;
        }
    }
}
