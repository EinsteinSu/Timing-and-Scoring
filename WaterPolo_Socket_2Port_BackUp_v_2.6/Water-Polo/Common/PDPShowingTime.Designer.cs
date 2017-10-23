namespace Common
{
    partial class PDPShowingTime
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
            this.lbTimingType = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.plMLeft = new System.Windows.Forms.Panel();
            this.plMRight = new System.Windows.Forms.Panel();
            this.plMTop = new System.Windows.Forms.Panel();
            this.plMBottom = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTimingType
            // 
            this.lbTimingType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTimingType.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimingType.ForeColor = System.Drawing.Color.Gold;
            this.lbTimingType.Location = new System.Drawing.Point(0, 0);
            this.lbTimingType.Name = "lbTimingType";
            this.lbTimingType.Size = new System.Drawing.Size(594, 132);
            this.lbTimingType.TabIndex = 3;
            this.lbTimingType.Text = "Timing type";
            this.lbTimingType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTime
            // 
            this.lbTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTime.Font = new System.Drawing.Font("Agency FB", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Gold;
            this.lbTime.Location = new System.Drawing.Point(3, 135);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(594, 183);
            this.lbTime.TabIndex = 7;
            this.lbTime.Tag = "";
            this.lbTime.Text = "00:00";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTimingType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 132);
            this.panel2.TabIndex = 6;
            // 
            // plMLeft
            // 
            this.plMLeft.BackColor = System.Drawing.Color.Lime;
            this.plMLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.plMLeft.Location = new System.Drawing.Point(0, 3);
            this.plMLeft.Name = "plMLeft";
            this.plMLeft.Size = new System.Drawing.Size(3, 315);
            this.plMLeft.TabIndex = 3;
            // 
            // plMRight
            // 
            this.plMRight.BackColor = System.Drawing.Color.Lime;
            this.plMRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.plMRight.Location = new System.Drawing.Point(597, 3);
            this.plMRight.Name = "plMRight";
            this.plMRight.Size = new System.Drawing.Size(3, 315);
            this.plMRight.TabIndex = 2;
            // 
            // plMTop
            // 
            this.plMTop.BackColor = System.Drawing.Color.Lime;
            this.plMTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plMTop.Location = new System.Drawing.Point(0, 0);
            this.plMTop.Name = "plMTop";
            this.plMTop.Size = new System.Drawing.Size(600, 3);
            this.plMTop.TabIndex = 0;
            // 
            // plMBottom
            // 
            this.plMBottom.BackColor = System.Drawing.Color.Lime;
            this.plMBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plMBottom.Location = new System.Drawing.Point(0, 318);
            this.plMBottom.Name = "plMBottom";
            this.plMBottom.Size = new System.Drawing.Size(600, 3);
            this.plMBottom.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.lbTime);
            this.panel13.Controls.Add(this.panel2);
            this.panel13.Controls.Add(this.plMLeft);
            this.panel13.Controls.Add(this.plMRight);
            this.panel13.Controls.Add(this.plMBottom);
            this.panel13.Controls.Add(this.plMTop);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(600, 321);
            this.panel13.TabIndex = 9;
            // 
            // PDPShowingTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 321);
            this.Controls.Add(this.panel13);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PDPShowingTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PDPShowingTime";
            this.TopMost = true;
            this.panel2.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTimingType;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel plMLeft;
        private System.Windows.Forms.Panel plMRight;
        private System.Windows.Forms.Panel plMTop;
        private System.Windows.Forms.Panel plMBottom;
        private System.Windows.Forms.Panel panel13;
    }
}