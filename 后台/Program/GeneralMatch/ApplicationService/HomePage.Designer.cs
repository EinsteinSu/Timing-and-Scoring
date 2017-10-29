namespace ApplicationService
{
    partial class HomePage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btTools = new ApplicationControlCommon.MyButton();
            this.btBroadCast = new ApplicationControlCommon.MyButton();
            this.btSetting = new ApplicationControlCommon.MyButton();
            this.btInfo = new ApplicationControlCommon.MyButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbFunctions = new System.Windows.Forms.GroupBox();
            this.pcService = new ApplicationControlCommon.ParentControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btTools, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btBroadCast, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btSetting, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btInfo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(152, 476);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btTools
            // 
            this.btTools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btTools.EnglishText = null;
            this.btTools.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTools.FOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btTools.FOCUSFONTCOLOR = System.Drawing.SystemColors.ControlText;
            this.btTools.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btTools.Image = ((System.Drawing.Image)(resources.GetObject("btTools.Image")));
            this.btTools.Location = new System.Drawing.Point(3, 360);
            this.btTools.Name = "btTools";
            this.btTools.Size = new System.Drawing.Size(146, 113);
            this.btTools.TabIndex = 3;
            this.btTools.Text = "工具";
            this.btTools.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btTools.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btTools.UNFOCUSFONTCOLOR = System.Drawing.SystemColors.ControlText;
            this.btTools.UseVisualStyleBackColor = true;
            this.btTools.Click += new System.EventHandler(this.btTools_Click);
            // 
            // btBroadCast
            // 
            this.btBroadCast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btBroadCast.EnglishText = null;
            this.btBroadCast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBroadCast.FOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btBroadCast.FOCUSFONTCOLOR = System.Drawing.SystemColors.ControlText;
            this.btBroadCast.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btBroadCast.Image = ((System.Drawing.Image)(resources.GetObject("btBroadCast.Image")));
            this.btBroadCast.Location = new System.Drawing.Point(3, 241);
            this.btBroadCast.Name = "btBroadCast";
            this.btBroadCast.Size = new System.Drawing.Size(146, 113);
            this.btBroadCast.TabIndex = 2;
            this.btBroadCast.Text = "广播";
            this.btBroadCast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btBroadCast.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btBroadCast.UNFOCUSFONTCOLOR = System.Drawing.SystemColors.ControlText;
            this.btBroadCast.UseVisualStyleBackColor = true;
            this.btBroadCast.Click += new System.EventHandler(this.btBroadCast_Click);
            // 
            // btSetting
            // 
            this.btSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btSetting.EnglishText = null;
            this.btSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSetting.FOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSetting.FOCUSFONTCOLOR = System.Drawing.SystemColors.ControlText;
            this.btSetting.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSetting.Image = ((System.Drawing.Image)(resources.GetObject("btSetting.Image")));
            this.btSetting.Location = new System.Drawing.Point(3, 122);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(146, 113);
            this.btSetting.TabIndex = 1;
            this.btSetting.Text = "设置";
            this.btSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSetting.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSetting.UNFOCUSFONTCOLOR = System.Drawing.SystemColors.ControlText;
            this.btSetting.UseVisualStyleBackColor = true;
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            // 
            // btInfo
            // 
            this.btInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btInfo.EnglishText = null;
            this.btInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btInfo.FOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btInfo.FOCUSFONTCOLOR = System.Drawing.SystemColors.ControlText;
            this.btInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btInfo.Image = ((System.Drawing.Image)(resources.GetObject("btInfo.Image")));
            this.btInfo.Location = new System.Drawing.Point(3, 3);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(146, 113);
            this.btInfo.TabIndex = 0;
            this.btInfo.Text = "服务";
            this.btInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btInfo.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btInfo.UNFOCUSFONTCOLOR = System.Drawing.SystemColors.ControlText;
            this.btInfo.UseVisualStyleBackColor = true;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 496);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // gbFunctions
            // 
            this.gbFunctions.Controls.Add(this.pcService);
            this.gbFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFunctions.Location = new System.Drawing.Point(158, 0);
            this.gbFunctions.Name = "gbFunctions";
            this.gbFunctions.Size = new System.Drawing.Size(480, 496);
            this.gbFunctions.TabIndex = 2;
            this.gbFunctions.TabStop = false;
            // 
            // pcService
            // 
            this.pcService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcService.Location = new System.Drawing.Point(3, 17);
            this.pcService.Name = "pcService";
            this.pcService.Size = new System.Drawing.Size(474, 476);
            this.pcService.TabIndex = 3;
            this.pcService.ShowControled += new ApplicationControlCommon.ParentControl.ShowControledCallback(this.pcService_ShowControled);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 496);
            this.CLOSETEXT = "是否关闭服务端？";
            this.Controls.Add(this.gbFunctions);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ISSHOWMESSAGE = true;
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbFunctions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ApplicationControlCommon.MyButton btTools;
        private ApplicationControlCommon.MyButton btBroadCast;
        private ApplicationControlCommon.MyButton btSetting;
        private ApplicationControlCommon.MyButton btInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbFunctions;
        private ApplicationControlCommon.ParentControl pcService;
    }
}

