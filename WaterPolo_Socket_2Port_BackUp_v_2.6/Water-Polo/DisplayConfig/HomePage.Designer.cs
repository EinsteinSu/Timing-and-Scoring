namespace DisplayConfig
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
            this.btTesting = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbServicePort = new System.Windows.Forms.TextBox();
            this.tbServiceIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btSetting = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbListeningPort = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbWelcome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btTesting
            // 
            this.btTesting.Location = new System.Drawing.Point(596, 394);
            this.btTesting.Margin = new System.Windows.Forms.Padding(4);
            this.btTesting.Name = "btTesting";
            this.btTesting.Size = new System.Drawing.Size(100, 31);
            this.btTesting.TabIndex = 25;
            this.btTesting.Text = "测试";
            this.btTesting.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbServicePort);
            this.groupBox1.Controls.Add(this.tbServiceIP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 155);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(444, 116);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务端";
            // 
            // tbServicePort
            // 
            this.tbServicePort.Location = new System.Drawing.Point(67, 67);
            this.tbServicePort.Margin = new System.Windows.Forms.Padding(4);
            this.tbServicePort.Name = "tbServicePort";
            this.tbServicePort.Size = new System.Drawing.Size(368, 22);
            this.tbServicePort.TabIndex = 3;
            // 
            // tbServiceIP
            // 
            this.tbServiceIP.Location = new System.Drawing.Point(107, 31);
            this.tbServiceIP.Margin = new System.Windows.Forms.Padding(4);
            this.tbServiceIP.Name = "tbServiceIP";
            this.tbServiceIP.Size = new System.Drawing.Size(328, 22);
            this.tbServiceIP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP地址";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(812, 395);
            this.btClose.Margin = new System.Windows.Forms.Padding(4);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 31);
            this.btClose.TabIndex = 27;
            this.btClose.Text = "关闭";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSetting
            // 
            this.btSetting.Location = new System.Drawing.Point(704, 394);
            this.btSetting.Margin = new System.Windows.Forms.Padding(4);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(100, 31);
            this.btSetting.TabIndex = 26;
            this.btSetting.Text = "设置";
            this.btSetting.UseVisualStyleBackColor = true;
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(192, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(430, 46);
            this.label10.TabIndex = 30;
            this.label10.Text = "水球比赛显示平台设置";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.tbHeight);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbListeningPort);
            this.groupBox3.Controls.Add(this.tbWidth);
            this.groupBox3.Controls.Add(this.tbY);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbX);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(468, 155);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(444, 116);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PDP";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(389, 67);
            this.tbHeight.Margin = new System.Windows.Forms.Padding(4);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(43, 22);
            this.tbHeight.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "高";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "侦听端口";
            // 
            // tbListeningPort
            // 
            this.tbListeningPort.Location = new System.Drawing.Point(135, 31);
            this.tbListeningPort.Margin = new System.Windows.Forms.Padding(4);
            this.tbListeningPort.Name = "tbListeningPort";
            this.tbListeningPort.Size = new System.Drawing.Size(300, 22);
            this.tbListeningPort.TabIndex = 1;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(272, 67);
            this.tbWidth.Margin = new System.Windows.Forms.Padding(4);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(45, 22);
            this.tbWidth.TabIndex = 8;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(145, 68);
            this.tbY.Margin = new System.Windows.Forms.Padding(4);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(33, 22);
            this.tbY.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "宽";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(49, 68);
            this.tbX.Margin = new System.Windows.Forms.Padding(4);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(33, 22);
            this.tbX.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Y";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.tbPrice);
            this.groupBox2.Controls.Add(this.tbWelcome);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(16, 278);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(444, 116);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "其他显示";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(107, 67);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(328, 22);
            this.tbPrice.TabIndex = 3;
            // 
            // tbWelcome
            // 
            this.tbWelcome.Location = new System.Drawing.Point(107, 31);
            this.tbWelcome.Margin = new System.Windows.Forms.Padding(4);
            this.tbWelcome.Name = "tbWelcome";
            this.tbWelcome.Size = new System.Drawing.Size(328, 22);
            this.tbWelcome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "颁奖界面";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "欢迎界面";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(933, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btTesting);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSetting);
            this.Controls.Add(this.label10);
            this.ENDCOLOR = System.Drawing.Color.SteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HomePage";
            this.ShowInTaskbar = true;
            this.STARTCOLOR = System.Drawing.SystemColors.ActiveCaption;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "显示平台设置";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTesting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbServicePort;
        private System.Windows.Forms.TextBox tbServiceIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSetting;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbListeningPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbWelcome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

