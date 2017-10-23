namespace Common
{
    partial class ShowingTimeOperate
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
            this.tcShowingTime = new TimingControl.TimingControl();
            this.SuspendLayout();
            // 
            // tcShowingTime
            // 
            this.tcShowingTime.DisplayFormat = "mm:ss";
            this.tcShowingTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcShowingTime.IsAdd = false;
            this.tcShowingTime.Location = new System.Drawing.Point(0, 0);
            this.tcShowingTime.LTime = 0;
            this.tcShowingTime.Name = "tcShowingTime";
            this.tcShowingTime.SettingTime = "00:00:00";
            this.tcShowingTime.ShowButtons = true;
            this.tcShowingTime.Size = new System.Drawing.Size(459, 207);
            this.tcShowingTime.TabIndex = 3;
            this.tcShowingTime.TimingBackColor = System.Drawing.Color.Empty;
            this.tcShowingTime.TimingForeColor = System.Drawing.Color.Empty;
            this.tcShowingTime.TimingLabelFont = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tcShowingTime.TimingTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tcShowingTime.TimeChanging += new TimingControl.TimingControl.TimeChangingCallback(this.tcShowingTime_TimeChanging);
            this.tcShowingTime.TextTimingChanged += new TimingControl.TimingControl.TextTimingChangedCallback(this.tcShowingTime_TextTimingChanged);
            // 
            // ShowingTimeOperate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 254);
            this.Controls.Add(this.tcShowingTime);
            this.DoubleBuffered = true;
            this.Name = "ShowingTimeOperate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ShowingTimeOperate";
            this.OkClick += new ApplicationControlCommon.DialogForm.OkClickCallback(this.ShowingTimeOperate_OkClick);
            this.CancelClick += new ApplicationControlCommon.DialogForm.CancelClickCallback(this.ShowingTimeOperate_CancelClick);
            this.Controls.SetChildIndex(this.tcShowingTime, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private TimingControl.TimingControl tcShowingTime;
    }
}