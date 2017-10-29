namespace ApplicationControlCommon
{
    partial class NotifyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyForm));
            this.ntfForm = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // ntfForm
            // 
            this.ntfForm.ContextMenuStrip = this.cms;
            this.ntfForm.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfForm.Icon")));
            this.ntfForm.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntfForm_MouseDoubleClick);
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDisplay,
            this.tsmQuit});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(119, 48);
            // 
            // tsmDisplay
            // 
            this.tsmDisplay.Image = ((System.Drawing.Image)(resources.GetObject("tsmDisplay.Image")));
            this.tsmDisplay.Name = "tsmDisplay";
            this.tsmDisplay.Size = new System.Drawing.Size(118, 22);
            this.tsmDisplay.Text = "显示(&D)";
            this.tsmDisplay.Click += new System.EventHandler(this.tsmDisplay_Click);
            // 
            // tsmQuit
            // 
            this.tsmQuit.Image = ((System.Drawing.Image)(resources.GetObject("tsmQuit.Image")));
            this.tsmQuit.Name = "tsmQuit";
            this.tsmQuit.Size = new System.Drawing.Size(118, 22);
            this.tsmQuit.Text = "退出(&Q)";
            this.tsmQuit.Click += new System.EventHandler(this.tsmQuit_Click);
            // 
            // NotifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 392);
            this.Name = "NotifyForm";
            this.Text = "NotifyForm";
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.NotifyIcon ntfForm;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmDisplay;
        private System.Windows.Forms.ToolStripMenuItem tsmQuit;
    }
}