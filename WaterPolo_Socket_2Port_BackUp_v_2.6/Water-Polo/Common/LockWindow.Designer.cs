namespace Common
{
    partial class LockWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lueUser = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.lbInfo = new DevExpress.XtraEditors.LabelControl();
            this.btSetting = new ApplicationControlCommon.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(64, 136);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F);
            this.tbPassword.Properties.Appearance.Options.UseFont = true;
            this.tbPassword.Properties.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(237, 21);
            this.tbPassword.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(19, 139);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 15);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "密    码:";
            // 
            // lueUser
            // 
            this.lueUser.Location = new System.Drawing.Point(64, 109);
            this.lueUser.Name = "lueUser";
            this.lueUser.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F);
            this.lueUser.Properties.Appearance.Options.UseFont = true;
            this.lueUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUser.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("USERNAME", "用户名", 41, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueUser.Properties.DisplayMember = "USERNAME";
            this.lueUser.Properties.ValueMember = "GUID";
            this.lueUser.Size = new System.Drawing.Size(237, 21);
            this.lueUser.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(19, 112);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 15);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "用户名:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 56);
            this.label1.TabIndex = 16;
            this.label1.Text = "窗口已被锁定，请验证密码！";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbInfo
            // 
            this.lbInfo.Appearance.Font = new System.Drawing.Font("Arial", 9F);
            this.lbInfo.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbInfo.Appearance.Options.UseFont = true;
            this.lbInfo.Appearance.Options.UseForeColor = true;
            this.lbInfo.Location = new System.Drawing.Point(19, 172);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(0, 15);
            this.lbInfo.TabIndex = 17;
            // 
            // btSetting
            // 
            this.btSetting.EnglishText = null;
            this.btSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSetting.FOCUSFONT = null;
            this.btSetting.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btSetting.Location = new System.Drawing.Point(215, 164);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(86, 32);
            this.btSetting.TabIndex = 18;
            this.btSetting.Text = "确定";
            this.btSetting.UNFOCUSFONT = null;
            this.btSetting.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            // 
            // LockWindow
            // 
            this.AcceptButton = this.btSetting;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(318, 210);
            this.COLORANGLE = 3F;
            this.Controls.Add(this.btSetting);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lueUser);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureBox1);
            this.ENDCOLOR = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LockWindow";
            this.STARTCOLOR = System.Drawing.SystemColors.ActiveCaption;
            this.Text = "LockWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUser.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit tbPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lueUser;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl lbInfo;
        private ApplicationControlCommon.MyButton btSetting;
    }
}