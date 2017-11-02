namespace RefereeConsole
{
    partial class AthletesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AthletesControl));
            this.btCancel = new System.Windows.Forms.Button();
            this.lbTwentyTime = new System.Windows.Forms.Label();
            this.cbSerious = new DevExpress.XtraEditors.CheckEdit();
            this.lbFoulsCount = new System.Windows.Forms.Label();
            this.btSubFoul = new System.Windows.Forms.Button();
            this.btAddFoul = new System.Windows.Forms.Button();
            this.lbNumber = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btStart = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cbSerious.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCancel.Enabled = false;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancel.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(0, 23);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(85, 22);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lbTwentyTime
            // 
            this.lbTwentyTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTwentyTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTwentyTime.Font = new System.Drawing.Font("Agency FB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(10)));
            this.lbTwentyTime.ForeColor = System.Drawing.Color.Red;
            this.lbTwentyTime.Location = new System.Drawing.Point(333, 0);
            this.lbTwentyTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTwentyTime.Name = "lbTwentyTime";
            this.lbTwentyTime.Size = new System.Drawing.Size(46, 45);
            this.lbTwentyTime.TabIndex = 1;
            this.lbTwentyTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTwentyTime.TextChanged += new System.EventHandler(this.lbTwentyTime_TextChanged);
            // 
            // cbSerious
            // 
            this.cbSerious.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbSerious.Location = new System.Drawing.Point(301, 0);
            this.cbSerious.Margin = new System.Windows.Forms.Padding(4);
            this.cbSerious.Name = "cbSerious";
            this.cbSerious.Properties.AutoHeight = false;
            this.cbSerious.Properties.Caption = "";
            this.cbSerious.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            this.cbSerious.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbSerious.Properties.PictureChecked = ((System.Drawing.Image)(resources.GetObject("cbSerious.Properties.PictureChecked")));
            this.cbSerious.Properties.ValueChecked = 1;
            this.cbSerious.Properties.ValueUnchecked = 0;
            this.cbSerious.Size = new System.Drawing.Size(32, 45);
            this.cbSerious.TabIndex = 2;
            this.cbSerious.CheckedChanged += new System.EventHandler(this.cbSerious_CheckedChanged);
            // 
            // lbFoulsCount
            // 
            this.lbFoulsCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFoulsCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbFoulsCount.Font = new System.Drawing.Font("Agency FB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(10)));
            this.lbFoulsCount.Location = new System.Drawing.Point(243, 0);
            this.lbFoulsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFoulsCount.Name = "lbFoulsCount";
            this.lbFoulsCount.Size = new System.Drawing.Size(22, 45);
            this.lbFoulsCount.TabIndex = 5;
            this.lbFoulsCount.Text = "0";
            this.lbFoulsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSubFoul
            // 
            this.btSubFoul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSubFoul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSubFoul.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubFoul.Location = new System.Drawing.Point(0, 23);
            this.btSubFoul.Margin = new System.Windows.Forms.Padding(4);
            this.btSubFoul.Name = "btSubFoul";
            this.btSubFoul.Size = new System.Drawing.Size(36, 22);
            this.btSubFoul.TabIndex = 1;
            this.btSubFoul.Text = "-";
            this.btSubFoul.UseVisualStyleBackColor = true;
            this.btSubFoul.Click += new System.EventHandler(this.btSubFoul_Click);
            // 
            // btAddFoul
            // 
            this.btAddFoul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAddFoul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAddFoul.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddFoul.Location = new System.Drawing.Point(0, 0);
            this.btAddFoul.Margin = new System.Windows.Forms.Padding(4);
            this.btAddFoul.Name = "btAddFoul";
            this.btAddFoul.Size = new System.Drawing.Size(36, 23);
            this.btAddFoul.TabIndex = 0;
            this.btAddFoul.Text = "+";
            this.btAddFoul.UseVisualStyleBackColor = true;
            this.btAddFoul.Click += new System.EventHandler(this.btAddFoul_Click);
            // 
            // lbNumber
            // 
            this.lbNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbNumber.Font = new System.Drawing.Font("Agency FB", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.Location = new System.Drawing.Point(0, 0);
            this.lbNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(42, 45);
            this.lbNumber.TabIndex = 6;
            this.lbNumber.Text = "0";
            this.lbNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(10)));
            this.lbName.Location = new System.Drawing.Point(42, 0);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(201, 45);
            this.lbName.TabIndex = 7;
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCancel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(379, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 45);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(85, 23);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btStart);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(85, 23);
            this.panel5.TabIndex = 0;
            // 
            // btStart
            // 
            this.btStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btStart.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(0, 0);
            this.btStart.Margin = new System.Windows.Forms.Padding(4);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(85, 23);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btSubFoul);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(265, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(36, 45);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btAddFoul);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(36, 23);
            this.panel4.TabIndex = 0;
            // 
            // AthletesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbFoulsCount);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cbSerious);
            this.Controls.Add(this.lbTwentyTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbNumber);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AthletesControl";
            this.Size = new System.Drawing.Size(464, 45);
            ((System.ComponentModel.ISupportInitialize)(this.cbSerious.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbTwentyTime;
        private DevExpress.XtraEditors.CheckEdit cbSerious;
        private System.Windows.Forms.Label lbFoulsCount;
        private System.Windows.Forms.Button btSubFoul;
        private System.Windows.Forms.Button btAddFoul;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btStart;
    }
}
