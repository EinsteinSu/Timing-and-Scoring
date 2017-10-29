using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using ClientCommon;

namespace ClientControlCommon
{
    public class FunctionsTaskButton : ToolStripButton
    {
        public FunctionsTaskButton(string title, Image image)
            : base(title, image)
        {
            base.ImageScaling = ToolStripItemImageScaling.None;
            if (cmsButton == null)
                InitializeComponent();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (cmsButton != null)
                    cmsButton.Show(Cursor.Position.X, Cursor.Position.Y + 42);
            }
        }

        #region 右键菜单
        private ContextMenuStrip cmsButton;
        private System.ComponentModel.IContainer components;
        private ToolStripMenuItem tsmClose;
        private ToolStripMenuItem tsmCloseOther;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmAdd;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem tsmAttributes;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmsButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCloseOther = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAttributes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsButton.SuspendLayout();
            // 
            // cmsButton
            // 
            this.cmsButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmClose,
            this.tsmCloseOther,
            this.toolStripSeparator1,
            this.tsmAdd,
            this.toolStripSeparator2,
            this.tsmAttributes});
            this.cmsButton.Name = "cmsButton";
            this.cmsButton.Size = new System.Drawing.Size(149, 104);
            // 
            // tsmClose
            // 
            this.tsmClose.Name = "tsmClose";
            this.tsmClose.Size = new System.Drawing.Size(148, 22);
            this.tsmClose.Text = "关闭";
            this.tsmClose.Click += new System.EventHandler(this.tsmClose_Click);
            // 
            // tsmCloseOther
            // 
            this.tsmCloseOther.Name = "tsmCloseOther";
            this.tsmCloseOther.Size = new System.Drawing.Size(148, 22);
            this.tsmCloseOther.Text = "关闭其他";
            this.tsmCloseOther.Click += new System.EventHandler(this.tsmCloseOther_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // tsmAdd
            // 
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(148, 22);
            this.tsmAdd.Text = "添加到快捷栏";
            this.tsmAdd.Click += new System.EventHandler(this.tsmAdd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // tsmAttributes
            // 
            this.tsmAttributes.Name = "tsmAttributes";
            this.tsmAttributes.Size = new System.Drawing.Size(148, 22);
            this.tsmAttributes.Text = "属性";
            this.tsmAttributes.Click += new System.EventHandler(this.tsmAttributes_Click);
            this.cmsButton.ResumeLayout(false);

        }
        #endregion

        public delegate void CloseClickCallback(Functions f, FunctionsTaskButton bt);
        public event CloseClickCallback CloseClick;
        private void tsmClose_Click(object sender, EventArgs e)
        {
            if (CloseClick != null)
                CloseClick(this.Tag as Functions, this);
        }

        public delegate void CloseOtherClickCallback(FunctionsTaskButton bt);
        public event CloseOtherClickCallback CloseOtherClick;
        private void tsmCloseOther_Click(object sender, EventArgs e)
        {
            if (CloseOtherClick != null)
                CloseOtherClick(this);

        }

        public delegate void AddFastMenuCallback();
        public event AddFastMenuCallback AddFastMenu;
        private void tsmAdd_Click(object sender, EventArgs e)
        {
            Functions f = this.Tag as Functions;
            if (f != null)
            {
                FastMenum.Add(f.GUID);
            }
        }

        private void tsmAttributes_Click(object sender, EventArgs e)
        {
            FunctionAttribute frm = new FunctionAttribute(this.Tag as ClientCommon.Functions);
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
