namespace ApplicationClient
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.functionMenum = new ClientControlCommon.FunctionMenum();
            this.panel1 = new System.Windows.Forms.Panel();
            this.functionTask = new ClientControlCommon.FunctionsTask();
            this.btFastMenum = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btDeskTop = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.broadcastPanel1 = new ClientControlCommon.BroadcastPanel();
            this.loginViewPanel1 = new ClientControlCommon.LoginViewPanel();
            this.plParent = new System.Windows.Forms.Panel();
            this.tlpHome = new System.Windows.Forms.TableLayoutPanel();
            this.lbNameEn = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pbFunctionImage = new System.Windows.Forms.PictureBox();
            this.lbClose = new ApplicationControlCommon.ImageLabel();
            this.panel1.SuspendLayout();
            this.functionTask.SuspendLayout();
            this.panel2.SuspendLayout();
            this.plParent.SuspendLayout();
            this.tlpHome.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFunctionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // functionMenum
            // 
            this.functionMenum.BackColor = System.Drawing.SystemColors.Control;
            this.functionMenum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("functionMenum.BackgroundImage")));
            this.functionMenum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.functionMenum.Location = new System.Drawing.Point(0, 0);
            this.functionMenum.Name = "functionMenum";
            this.functionMenum.Size = new System.Drawing.Size(865, 24);
            this.functionMenum.TabIndex = 0;
            this.functionMenum.Text = "functionMenum1";
            this.functionMenum.MenumClick += new ClientControlCommon.FunctionMenum.OnMenumClick(this.functionMenum_MenumClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.functionTask);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 42);
            this.panel1.TabIndex = 1;
            // 
            // functionTask
            // 
            this.functionTask.AutoSize = false;
            this.functionTask.BackColor = System.Drawing.SystemColors.Control;
            this.functionTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("functionTask.BackgroundImage")));
            this.functionTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.functionTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.functionTask.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.functionTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btFastMenum,
            this.toolStripSeparator1,
            this.btDeskTop});
            this.functionTask.Location = new System.Drawing.Point(0, 0);
            this.functionTask.Name = "functionTask";
            this.functionTask.Size = new System.Drawing.Size(777, 42);
            this.functionTask.TabIndex = 3;
            this.functionTask.Text = "functionsTask1";
            this.functionTask.OnClose += new ClientControlCommon.FunctionsTask.CloseClickCallback(this.functionTask_OnClose);
            this.functionTask.OnFunctionsClick += new ClientControlCommon.FunctionsTask.FunctionsClickCallback(this.functionTask_OnFunctionsClick);
            // 
            // btFastMenum
            // 
            this.btFastMenum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btFastMenum.Image = ((System.Drawing.Image)(resources.GetObject("btFastMenum.Image")));
            this.btFastMenum.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btFastMenum.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btFastMenum.Name = "btFastMenum";
            this.btFastMenum.Size = new System.Drawing.Size(36, 39);
            this.btFastMenum.Text = "快捷菜单";
            this.btFastMenum.Click += new System.EventHandler(this.btFastMenum_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // btDeskTop
            // 
            this.btDeskTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDeskTop.Image = ((System.Drawing.Image)(resources.GetObject("btDeskTop.Image")));
            this.btDeskTop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btDeskTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDeskTop.Name = "btDeskTop";
            this.btDeskTop.Size = new System.Drawing.Size(36, 39);
            this.btDeskTop.Text = "显示桌面";
            this.btDeskTop.Click += new System.EventHandler(this.btDeskTop_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.broadcastPanel1);
            this.panel2.Controls.Add(this.loginViewPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(777, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(88, 42);
            this.panel2.TabIndex = 0;
            // 
            // broadcastPanel1
            // 
            this.broadcastPanel1.BackColor = System.Drawing.Color.Transparent;
            this.broadcastPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("broadcastPanel1.BackgroundImage")));
            this.broadcastPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.broadcastPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.broadcastPanel1.Location = new System.Drawing.Point(4, 0);
            this.broadcastPanel1.Name = "broadcastPanel1";
            this.broadcastPanel1.Size = new System.Drawing.Size(42, 42);
            this.broadcastPanel1.TabIndex = 1;
            // 
            // loginViewPanel1
            // 
            this.loginViewPanel1.BackColor = System.Drawing.Color.Transparent;
            this.loginViewPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginViewPanel1.BackgroundImage")));
            this.loginViewPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginViewPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.loginViewPanel1.Location = new System.Drawing.Point(46, 0);
            this.loginViewPanel1.Name = "loginViewPanel1";
            this.loginViewPanel1.Size = new System.Drawing.Size(42, 42);
            this.loginViewPanel1.TabIndex = 0;
            // 
            // plParent
            // 
            this.plParent.BackColor = System.Drawing.Color.White;
            this.plParent.Controls.Add(this.tlpHome);
            this.plParent.Controls.Add(this.panel3);
            this.plParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plParent.Location = new System.Drawing.Point(0, 24);
            this.plParent.Name = "plParent";
            this.plParent.Size = new System.Drawing.Size(865, 447);
            this.plParent.TabIndex = 3;
            // 
            // tlpHome
            // 
            this.tlpHome.BackColor = System.Drawing.Color.White;
            this.tlpHome.ColumnCount = 3;
            this.tlpHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tlpHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpHome.Controls.Add(this.lbNameEn, 0, 3);
            this.tlpHome.Controls.Add(this.lbName, 0, 0);
            this.tlpHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHome.Location = new System.Drawing.Point(0, 42);
            this.tlpHome.Name = "tlpHome";
            this.tlpHome.RowCount = 4;
            this.tlpHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHome.Size = new System.Drawing.Size(865, 405);
            this.tlpHome.TabIndex = 5;
            // 
            // lbNameEn
            // 
            this.lbNameEn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNameEn.AutoSize = true;
            this.lbNameEn.BackColor = System.Drawing.Color.Transparent;
            this.tlpHome.SetColumnSpan(this.lbNameEn, 3);
            this.lbNameEn.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameEn.Location = new System.Drawing.Point(432, 303);
            this.lbNameEn.Name = "lbNameEn";
            this.lbNameEn.Size = new System.Drawing.Size(0, 41);
            this.lbNameEn.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.tlpHome.SetColumnSpan(this.lbName, 3);
            this.lbName.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(432, 16);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 48);
            this.lbName.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lbTitle);
            this.panel3.Controls.Add(this.pbFunctionImage);
            this.panel3.Controls.Add(this.lbClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(865, 42);
            this.panel3.TabIndex = 4;
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("新宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTitle.Location = new System.Drawing.Point(42, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(781, 42);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "主页";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbFunctionImage
            // 
            this.pbFunctionImage.BackColor = System.Drawing.Color.Transparent;
            this.pbFunctionImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbFunctionImage.Image = ((System.Drawing.Image)(resources.GetObject("pbFunctionImage.Image")));
            this.pbFunctionImage.Location = new System.Drawing.Point(0, 0);
            this.pbFunctionImage.Name = "pbFunctionImage";
            this.pbFunctionImage.Size = new System.Drawing.Size(42, 42);
            this.pbFunctionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFunctionImage.TabIndex = 6;
            this.pbFunctionImage.TabStop = false;
            // 
            // lbClose
            // 
            this.lbClose.BackColor = System.Drawing.Color.Transparent;
            this.lbClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbClose.FOUCEIMAGE = ((System.Drawing.Image)(resources.GetObject("lbClose.FOUCEIMAGE")));
            this.lbClose.Image = ((System.Drawing.Image)(resources.GetObject("lbClose.Image")));
            this.lbClose.Location = new System.Drawing.Point(823, 0);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(42, 42);
            this.lbClose.TabIndex = 5;
            this.lbClose.UNFOUCEIMAGE = ((System.Drawing.Image)(resources.GetObject("lbClose.UNFOUCEIMAGE")));
            this.lbClose.Visible = false;
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 513);
            this.CLOSETEXT = "是否关闭该系统？";
            this.Controls.Add(this.plParent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.functionMenum);
            this.DoubleBuffered = true;
            this.ENDCOLOR = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ISSHOWMESSAGE = true;
            this.MainMenuStrip = this.functionMenum;
            this.Name = "HomePage";
            this.Text = "主页";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.functionTask.ResumeLayout(false);
            this.functionTask.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.plParent.ResumeLayout(false);
            this.tlpHome.ResumeLayout(false);
            this.tlpHome.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFunctionImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClientControlCommon.FunctionMenum functionMenum;
        private System.Windows.Forms.Panel panel1;
        private ClientControlCommon.FunctionsTask functionTask;
        private System.Windows.Forms.ToolStripButton btFastMenum;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btDeskTop;
        private System.Windows.Forms.Panel panel2;
        private ClientControlCommon.LoginViewPanel loginViewPanel1;
        private System.Windows.Forms.Panel plParent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pbFunctionImage;
        private ApplicationControlCommon.ImageLabel lbClose;
        private ClientControlCommon.BroadcastPanel broadcastPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpHome;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbNameEn;

    }
}