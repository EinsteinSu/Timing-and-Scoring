namespace Water_Polo
{
    partial class ProcessData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessData));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btSchedule = new System.Windows.Forms.Button();
            this.btAthleticsENG = new System.Windows.Forms.Button();
            this.btAthleticsCHN = new System.Windows.Forms.Button();
            this.btTeamCHN = new System.Windows.Forms.Button();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.gcTable = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btInport = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btSchedule, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btAthleticsENG, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btAthleticsCHN, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btTeamCHN, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 515);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btSchedule
            // 
            this.btSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSchedule.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btSchedule.Image")));
            this.btSchedule.Location = new System.Drawing.Point(3, 387);
            this.btSchedule.Name = "btSchedule";
            this.btSchedule.Size = new System.Drawing.Size(194, 125);
            this.btSchedule.TabIndex = 5;
            this.btSchedule.Text = "赛事信息";
            this.btSchedule.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSchedule.UseVisualStyleBackColor = true;
            this.btSchedule.Click += new System.EventHandler(this.btSchedule_Click);
            // 
            // btAthleticsENG
            // 
            this.btAthleticsENG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btAthleticsENG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAthleticsENG.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAthleticsENG.Image = ((System.Drawing.Image)(resources.GetObject("btAthleticsENG.Image")));
            this.btAthleticsENG.Location = new System.Drawing.Point(3, 259);
            this.btAthleticsENG.Name = "btAthleticsENG";
            this.btAthleticsENG.Size = new System.Drawing.Size(194, 122);
            this.btAthleticsENG.TabIndex = 4;
            this.btAthleticsENG.Text = "运动员英文信息信息";
            this.btAthleticsENG.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAthleticsENG.UseVisualStyleBackColor = true;
            this.btAthleticsENG.Click += new System.EventHandler(this.btAthleticsENG_Click);
            // 
            // btAthleticsCHN
            // 
            this.btAthleticsCHN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btAthleticsCHN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAthleticsCHN.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAthleticsCHN.Image = ((System.Drawing.Image)(resources.GetObject("btAthleticsCHN.Image")));
            this.btAthleticsCHN.Location = new System.Drawing.Point(3, 131);
            this.btAthleticsCHN.Name = "btAthleticsCHN";
            this.btAthleticsCHN.Size = new System.Drawing.Size(194, 122);
            this.btAthleticsCHN.TabIndex = 3;
            this.btAthleticsCHN.Text = "运动员中文信息";
            this.btAthleticsCHN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAthleticsCHN.UseVisualStyleBackColor = true;
            this.btAthleticsCHN.Click += new System.EventHandler(this.btAthleticsCHN_Click);
            // 
            // btTeamCHN
            // 
            this.btTeamCHN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btTeamCHN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTeamCHN.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btTeamCHN.Image = ((System.Drawing.Image)(resources.GetObject("btTeamCHN.Image")));
            this.btTeamCHN.Location = new System.Drawing.Point(3, 3);
            this.btTeamCHN.Name = "btTeamCHN";
            this.btTeamCHN.Size = new System.Drawing.Size(194, 122);
            this.btTeamCHN.TabIndex = 1;
            this.btTeamCHN.Text = "队伍中文信息";
            this.btTeamCHN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btTeamCHN.UseVisualStyleBackColor = true;
            this.btTeamCHN.Click += new System.EventHandler(this.btTeamCHN_Click);
            // 
            // rtbInfo
            // 
            this.rtbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInfo.Location = new System.Drawing.Point(2, 23);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(567, 142);
            this.rtbInfo.TabIndex = 1;
            this.rtbInfo.Text = "";
            // 
            // gcTable
            // 
            this.gcTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTable.Location = new System.Drawing.Point(2, 55);
            this.gcTable.MainView = this.gridView1;
            this.gcTable.Name = "gcTable";
            this.gcTable.Size = new System.Drawing.Size(567, 291);
            this.gcTable.TabIndex = 2;
            this.gcTable.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcTable;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rtbInfo);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(200, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(571, 167);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "文件信息";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcTable);
            this.groupControl2.Controls.Add(this.panelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(200, 167);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(571, 348);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "导入信息";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btInport);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(567, 32);
            this.panelControl1.TabIndex = 3;
            // 
            // btInport
            // 
            this.btInport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btInport.Location = new System.Drawing.Point(2, 2);
            this.btInport.Name = "btInport";
            this.btInport.Size = new System.Drawing.Size(75, 28);
            this.btInport.TabIndex = 4;
            this.btInport.Text = "开始导入";
            this.btInport.UseVisualStyleBackColor = true;
            this.btInport.Click += new System.EventHandler(this.btInport_Click);
            // 
            // ProcessData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProcessData";
            this.Size = new System.Drawing.Size(771, 515);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btTeamCHN;
        private System.Windows.Forms.Button btSchedule;
        private System.Windows.Forms.Button btAthleticsENG;
        private System.Windows.Forms.Button btAthleticsCHN;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private DevExpress.XtraGrid.GridControl gcTable;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btInport;
    }
}
