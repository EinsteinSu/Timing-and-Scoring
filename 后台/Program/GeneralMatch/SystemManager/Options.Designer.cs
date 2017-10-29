namespace SystemManager
{
    partial class Options
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBroadCastPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbServicePort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbAutoLogin = new DevExpress.XtraEditors.CheckEdit();
            this.cbRememberPwd = new DevExpress.XtraEditors.CheckEdit();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbNameEn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbAutoLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRememberPwd.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBroadCastPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbServicePort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbIPAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务端连接设置";
            // 
            // tbBroadCastPort
            // 
            this.tbBroadCastPort.Location = new System.Drawing.Point(93, 47);
            this.tbBroadCastPort.Name = "tbBroadCastPort";
            this.tbBroadCastPort.Size = new System.Drawing.Size(129, 21);
            this.tbBroadCastPort.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "广播口号：";
            // 
            // tbServicePort
            // 
            this.tbServicePort.Location = new System.Drawing.Point(307, 20);
            this.tbServicePort.Name = "tbServicePort";
            this.tbServicePort.Size = new System.Drawing.Size(129, 21);
            this.tbServicePort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口号：";
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Location = new System.Drawing.Point(93, 20);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(129, 21);
            this.tbIPAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCP/IP地址：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbAutoLogin);
            this.groupBox2.Controls.Add(this.cbRememberPwd);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 60);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "登录设置";
            // 
            // cbAutoLogin
            // 
            this.cbAutoLogin.Location = new System.Drawing.Point(137, 20);
            this.cbAutoLogin.Name = "cbAutoLogin";
            this.cbAutoLogin.Properties.Caption = "自动登录";
            this.cbAutoLogin.Size = new System.Drawing.Size(75, 19);
            this.cbAutoLogin.TabIndex = 10;
            // 
            // cbRememberPwd
            // 
            this.cbRememberPwd.Location = new System.Drawing.Point(12, 20);
            this.cbRememberPwd.Name = "cbRememberPwd";
            this.cbRememberPwd.Properties.Caption = "记住密码";
            this.cbRememberPwd.Size = new System.Drawing.Size(75, 19);
            this.cbRememberPwd.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbNameEn);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 83);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "系统设置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "主页名称：";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(81, 24);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(355, 21);
            this.tbName.TabIndex = 2;
            // 
            // tbNameEn
            // 
            this.tbNameEn.Location = new System.Drawing.Point(129, 51);
            this.tbNameEn.Name = "tbNameEn";
            this.tbNameEn.Size = new System.Drawing.Size(307, 21);
            this.tbNameEn.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "主页名称（英文）：";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 310);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Options";
            this.Text = "选项";
            this.SettingClick += new ApplicationControlCommon.SettingsForm.SettingClickCallback(this.Options_SettingClick);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbAutoLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRememberPwd.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbBroadCastPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbServicePort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.CheckEdit cbAutoLogin;
        private DevExpress.XtraEditors.CheckEdit cbRememberPwd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbNameEn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
    }
}