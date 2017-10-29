namespace ApplicationClient
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNameEn = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbUserGuid = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbAutoLogin = new DevExpress.XtraEditors.CheckEdit();
            this.cbRememberPwd = new DevExpress.XtraEditors.CheckEdit();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btLogin = new ApplicationControlCommon.MyButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btSetting = new ApplicationControlCommon.MyButton();
            this.lbRelease = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbUserGuid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAutoLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRememberPwd.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.lbNameEn);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 123);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbNameEn
            // 
            this.lbNameEn.AutoSize = true;
            this.lbNameEn.BackColor = System.Drawing.Color.Transparent;
            this.lbNameEn.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNameEn.Location = new System.Drawing.Point(127, 96);
            this.lbNameEn.Name = "lbNameEn";
            this.lbNameEn.Size = new System.Drawing.Size(334, 24);
            this.lbNameEn.TabIndex = 1;
            this.lbNameEn.Text = "Athletes information system";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("宋体", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbName.Location = new System.Drawing.Point(125, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(303, 35);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "田径信息管理系统";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.cbUserGuid);
            this.panel2.Controls.Add(this.cbAutoLogin);
            this.panel2.Controls.Add(this.cbRememberPwd);
            this.panel2.Controls.Add(this.tbPassWord);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 94);
            this.panel2.TabIndex = 1;
            // 
            // cbUserGuid
            // 
            this.cbUserGuid.Location = new System.Drawing.Point(299, 6);
            this.cbUserGuid.Name = "cbUserGuid";
            this.cbUserGuid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUserGuid.Properties.ImmediatePopup = true;
            this.cbUserGuid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbUserGuid.Size = new System.Drawing.Size(175, 21);
            this.cbUserGuid.TabIndex = 9;
            // 
            // cbAutoLogin
            // 
            this.cbAutoLogin.Location = new System.Drawing.Point(378, 60);
            this.cbAutoLogin.Name = "cbAutoLogin";
            this.cbAutoLogin.Properties.Caption = "自动登录";
            this.cbAutoLogin.Size = new System.Drawing.Size(75, 19);
            this.cbAutoLogin.TabIndex = 8;
            this.cbAutoLogin.CheckedChanged += new System.EventHandler(this.cbAutoLogin_CheckedChanged);
            // 
            // cbRememberPwd
            // 
            this.cbRememberPwd.Location = new System.Drawing.Point(297, 60);
            this.cbRememberPwd.Name = "cbRememberPwd";
            this.cbRememberPwd.Properties.Caption = "记住密码";
            this.cbRememberPwd.Size = new System.Drawing.Size(75, 19);
            this.cbRememberPwd.TabIndex = 7;
            this.cbRememberPwd.CheckedChanged += new System.EventHandler(this.cbRememberPwd_CheckedChanged);
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(299, 33);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.PasswordChar = '*';
            this.tbPassWord.Size = new System.Drawing.Size(175, 21);
            this.tbPassWord.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密  码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // btLogin
            // 
            this.btLogin.EnglishText = null;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLogin.FOCUSFONT = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btLogin.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btLogin.Location = new System.Drawing.Point(626, 6);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "登录";
            this.btLogin.UNFOCUSFONT = null;
            this.btLogin.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(0, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(713, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "版权所有：Einstein";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btSetting);
            this.panel3.Controls.Add(this.btLogin);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(713, 38);
            this.panel3.TabIndex = 5;
            // 
            // btSetting
            // 
            this.btSetting.EnglishText = null;
            this.btSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSetting.FOCUSFONT = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSetting.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btSetting.Location = new System.Drawing.Point(545, 6);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(75, 23);
            this.btSetting.TabIndex = 5;
            this.btSetting.Text = "设置";
            this.btSetting.UNFOCUSFONT = null;
            this.btSetting.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btSetting.UseVisualStyleBackColor = true;
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            // 
            // lbRelease
            // 
            this.lbRelease.BackColor = System.Drawing.Color.Transparent;
            this.lbRelease.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbRelease.Location = new System.Drawing.Point(0, 265);
            this.lbRelease.Name = "lbRelease";
            this.lbRelease.Size = new System.Drawing.Size(713, 20);
            this.lbRelease.TabIndex = 6;
            this.lbRelease.Text = "版本号：V1.0";
            this.lbRelease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Login
            // 
            this.AcceptButton = this.btLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 305);
            this.Controls.Add(this.lbRelease);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ENDCOLOR = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.ShowInTaskbar = true;
            this.STARTCOLOR = System.Drawing.SystemColors.ActiveCaption;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbUserGuid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAutoLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRememberPwd.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private ApplicationControlCommon.MyButton btLogin;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbRelease;
        private ApplicationControlCommon.MyButton btSetting;
        private DevExpress.XtraEditors.CheckEdit cbAutoLogin;
        private DevExpress.XtraEditors.CheckEdit cbRememberPwd;
        private DevExpress.XtraEditors.ComboBoxEdit cbUserGuid;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbNameEn;
    }
}

