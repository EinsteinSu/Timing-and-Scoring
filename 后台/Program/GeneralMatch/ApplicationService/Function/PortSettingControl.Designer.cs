namespace ApplicationService
{
    partial class PortSettingControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortSettingControl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSystemPort = new System.Windows.Forms.TextBox();
            this.tbBroadCastPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSetting = new ApplicationControlCommon.MyButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSetting);
            this.groupBox1.Controls.Add(this.tbBroadCastPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbSystemPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "系统服务端口：";
            // 
            // tbSystemPort
            // 
            this.tbSystemPort.Location = new System.Drawing.Point(101, 20);
            this.tbSystemPort.Name = "tbSystemPort";
            this.tbSystemPort.Size = new System.Drawing.Size(205, 21);
            this.tbSystemPort.TabIndex = 1;
            // 
            // tbBroadCastPort
            // 
            this.tbBroadCastPort.Location = new System.Drawing.Point(77, 47);
            this.tbBroadCastPort.Name = "tbBroadCastPort";
            this.tbBroadCastPort.Size = new System.Drawing.Size(229, 21);
            this.tbBroadCastPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "广播端口：";
            // 
            // btSetting
            // 
            this.btSetting.EnglishText = null;
            this.btSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSetting.FOCUSFONT = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSetting.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btSetting.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSetting.Image = ((System.Drawing.Image)(resources.GetObject("btSetting.Image")));
            this.btSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSetting.Location = new System.Drawing.Point(231, 85);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(75, 23);
            this.btSetting.TabIndex = 4;
            this.btSetting.Text = "  设置";
            this.btSetting.UNFOCUSFONT = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSetting.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btSetting.UseVisualStyleBackColor = true;
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            // 
            // PortSettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "PortSettingControl";
            this.Size = new System.Drawing.Size(312, 114);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ApplicationControlCommon.MyButton btSetting;
        private System.Windows.Forms.TextBox tbBroadCastPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSystemPort;
        private System.Windows.Forms.Label label1;
    }
}
