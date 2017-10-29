namespace ApplicationService
{
    partial class InfomationControl
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
            this.rtbService = new ApplicationControlCommon.InfoDisplayRichTextBox();
            this.SuspendLayout();
            // 
            // rtbService
            // 
            this.rtbService.BackColor = System.Drawing.SystemColors.Window;
            this.rtbService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbService.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbService.Location = new System.Drawing.Point(0, 0);
            this.rtbService.Name = "rtbService";
            this.rtbService.ReadOnly = true;
            this.rtbService.Size = new System.Drawing.Size(589, 487);
            this.rtbService.TabIndex = 0;
            this.rtbService.Text = "";
            // 
            // InfomationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbService);
            this.Name = "InfomationControl";
            this.Size = new System.Drawing.Size(589, 487);
            this.ResumeLayout(false);

        }

        #endregion

        private ApplicationControlCommon.InfoDisplayRichTextBox rtbService;
    }
}
