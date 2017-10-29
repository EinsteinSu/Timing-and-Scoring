namespace ApplicationService
{
    partial class SettingControl
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.portSettingControl1 = new ApplicationService.PortSettingControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.sqlSettingControl1 = new ApplicationService.SqlSettingControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.serviceSettingControl1 = new ApplicationService.ServiceSettingControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(517, 410);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.portSettingControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(510, 380);
            this.xtraTabPage1.Text = "端口设置";
            // 
            // portSettingControl1
            // 
            this.portSettingControl1.Location = new System.Drawing.Point(3, 3);
            this.portSettingControl1.Name = "portSettingControl1";
            this.portSettingControl1.Size = new System.Drawing.Size(312, 114);
            this.portSettingControl1.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.sqlSettingControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(510, 380);
            this.xtraTabPage2.Text = "数据库设置";
            // 
            // sqlSettingControl1
            // 
            this.sqlSettingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlSettingControl1.Location = new System.Drawing.Point(0, 0);
            this.sqlSettingControl1.Name = "sqlSettingControl1";
            this.sqlSettingControl1.Size = new System.Drawing.Size(510, 380);
            this.sqlSettingControl1.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.serviceSettingControl1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(510, 380);
            this.xtraTabPage3.Text = "系统服务设置";
            // 
            // serviceSettingControl1
            // 
            this.serviceSettingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceSettingControl1.Location = new System.Drawing.Point(0, 0);
            this.serviceSettingControl1.Name = "serviceSettingControl1";
            this.serviceSettingControl1.Size = new System.Drawing.Size(510, 380);
            this.serviceSettingControl1.TabIndex = 0;
            // 
            // SettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "SettingControl";
            this.Size = new System.Drawing.Size(517, 410);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private PortSettingControl portSettingControl1;
        private SqlSettingControl sqlSettingControl1;
        private ServiceSettingControl serviceSettingControl1;
    }
}
