namespace ScheduleManager
{
    partial class TeamSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamSchedule));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.plButtons = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btAdd = new ApplicationControlCommon.MyButton();
            this.btAddChild = new ApplicationControlCommon.MyButton();
            this.btRefresh = new ApplicationControlCommon.MyButton();
            this.btSave = new ApplicationControlCommon.MyButton();
            this.btExpand = new ApplicationControlCommon.MyButton();
            this.btCollapse = new ApplicationControlCommon.MyButton();
            this.rbType = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.cbImages = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.tvSchedule = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.dtGameDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.dtGameTime = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.cTeamA = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.lueTeamA = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cTeamB = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.lueTeamB = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.lueGymnasium = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.lueArea = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.treeListColumn8 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.rbState = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.treeListColumn9 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn10 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cNum = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gcTeamB = new DevExpress.XtraGrid.GridControl();
            this.gvTeamB = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btAddTeamBAthletes = new ApplicationControlCommon.MyButton();
            this.btDeleteTeamBAthletes = new ApplicationControlCommon.MyButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gcTeamA = new DevExpress.XtraGrid.GridControl();
            this.gvTeamA = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btAddTeamAAthletes = new ApplicationControlCommon.MyButton();
            this.btDeleteTeamAAthletes = new ApplicationControlCommon.MyButton();
            this.plButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGameDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGameDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGameTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTeamA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTeamB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGymnasium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTeamB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTeamB)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTeamA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTeamA)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // plButtons
            // 
            this.plButtons.Controls.Add(this.tableLayoutPanel1);
            this.plButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.plButtons.Location = new System.Drawing.Point(0, 0);
            this.plButtons.Name = "plButtons";
            this.plButtons.Size = new System.Drawing.Size(850, 71);
            this.plButtons.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.btAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btAddChild, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btRefresh, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btSave, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btExpand, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btCollapse, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 71);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.EnglishText = null;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdd.FOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdd.Location = new System.Drawing.Point(93, 3);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(84, 65);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "增加父项";
            this.btAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdd.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btAddChild
            // 
            this.btAddChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddChild.EnglishText = null;
            this.btAddChild.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAddChild.FOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAddChild.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btAddChild.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAddChild.Image = ((System.Drawing.Image)(resources.GetObject("btAddChild.Image")));
            this.btAddChild.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAddChild.Location = new System.Drawing.Point(183, 3);
            this.btAddChild.Name = "btAddChild";
            this.btAddChild.Size = new System.Drawing.Size(84, 65);
            this.btAddChild.TabIndex = 1;
            this.btAddChild.Text = "增加子项";
            this.btAddChild.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAddChild.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAddChild.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btAddChild.UseVisualStyleBackColor = true;
            this.btAddChild.Click += new System.EventHandler(this.btAddChild_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btRefresh.EnglishText = null;
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRefresh.FOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRefresh.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btRefresh.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btRefresh.Image")));
            this.btRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRefresh.Location = new System.Drawing.Point(3, 3);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(84, 65);
            this.btRefresh.TabIndex = 0;
            this.btRefresh.Text = "刷新";
            this.btRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRefresh.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRefresh.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.EnglishText = null;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.FOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSave.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSave.Location = new System.Drawing.Point(273, 3);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(84, 65);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "保存";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSave.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSave.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btExpand
            // 
            this.btExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btExpand.EnglishText = null;
            this.btExpand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btExpand.FOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExpand.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btExpand.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExpand.Image = ((System.Drawing.Image)(resources.GetObject("btExpand.Image")));
            this.btExpand.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btExpand.Location = new System.Drawing.Point(453, 3);
            this.btExpand.Name = "btExpand";
            this.btExpand.Size = new System.Drawing.Size(84, 65);
            this.btExpand.TabIndex = 4;
            this.btExpand.Text = "展开";
            this.btExpand.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExpand.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExpand.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btExpand.UseVisualStyleBackColor = true;
            this.btExpand.Click += new System.EventHandler(this.btExpand_Click);
            // 
            // btCollapse
            // 
            this.btCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btCollapse.EnglishText = null;
            this.btCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCollapse.FOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCollapse.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btCollapse.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCollapse.Image = ((System.Drawing.Image)(resources.GetObject("btCollapse.Image")));
            this.btCollapse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCollapse.Location = new System.Drawing.Point(543, 3);
            this.btCollapse.Name = "btCollapse";
            this.btCollapse.Size = new System.Drawing.Size(84, 65);
            this.btCollapse.TabIndex = 5;
            this.btCollapse.Text = "收缩";
            this.btCollapse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCollapse.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCollapse.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btCollapse.UseVisualStyleBackColor = true;
            this.btCollapse.Click += new System.EventHandler(this.btCollapse_Click);
            // 
            // rbType
            // 
            this.rbType.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Null", "无"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("UserControl", "用户控件"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Method", "方法")});
            this.rbType.Name = "rbType";
            // 
            // cbImages
            // 
            this.cbImages.AutoHeight = false;
            this.cbImages.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbImages.Name = "cbImages";
            // 
            // tvSchedule
            // 
            this.tvSchedule.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tvSchedule.Appearance.Empty.Options.UseBackColor = true;
            this.tvSchedule.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.tvSchedule.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.tvSchedule.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.tvSchedule.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.tvSchedule.Appearance.EvenRow.Options.UseBackColor = true;
            this.tvSchedule.Appearance.EvenRow.Options.UseForeColor = true;
            this.tvSchedule.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.tvSchedule.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.tvSchedule.Appearance.FocusedCell.Options.UseBackColor = true;
            this.tvSchedule.Appearance.FocusedCell.Options.UseForeColor = true;
            this.tvSchedule.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy;
            this.tvSchedule.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.tvSchedule.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.tvSchedule.Appearance.FocusedRow.Options.UseBackColor = true;
            this.tvSchedule.Appearance.FocusedRow.Options.UseForeColor = true;
            this.tvSchedule.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.tvSchedule.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.tvSchedule.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.tvSchedule.Appearance.FooterPanel.Options.UseBackColor = true;
            this.tvSchedule.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.tvSchedule.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tvSchedule.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.tvSchedule.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.tvSchedule.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.tvSchedule.Appearance.GroupButton.Options.UseBackColor = true;
            this.tvSchedule.Appearance.GroupButton.Options.UseBorderColor = true;
            this.tvSchedule.Appearance.GroupButton.Options.UseForeColor = true;
            this.tvSchedule.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.tvSchedule.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.tvSchedule.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.tvSchedule.Appearance.GroupFooter.Options.UseBackColor = true;
            this.tvSchedule.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.tvSchedule.Appearance.GroupFooter.Options.UseForeColor = true;
            this.tvSchedule.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.tvSchedule.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.tvSchedule.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.tvSchedule.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.tvSchedule.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.tvSchedule.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.tvSchedule.Appearance.HeaderPanel.Options.UseFont = true;
            this.tvSchedule.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tvSchedule.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.tvSchedule.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.tvSchedule.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.tvSchedule.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.tvSchedule.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.tvSchedule.Appearance.HorzLine.Options.UseBackColor = true;
            this.tvSchedule.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.tvSchedule.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.tvSchedule.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.tvSchedule.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.tvSchedule.Appearance.OddRow.Options.UseBackColor = true;
            this.tvSchedule.Appearance.OddRow.Options.UseForeColor = true;
            this.tvSchedule.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.tvSchedule.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.tvSchedule.Appearance.Preview.Options.UseBackColor = true;
            this.tvSchedule.Appearance.Preview.Options.UseForeColor = true;
            this.tvSchedule.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.tvSchedule.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.tvSchedule.Appearance.Row.Options.UseBackColor = true;
            this.tvSchedule.Appearance.Row.Options.UseForeColor = true;
            this.tvSchedule.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.tvSchedule.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.tvSchedule.Appearance.SelectedRow.Options.UseBackColor = true;
            this.tvSchedule.Appearance.SelectedRow.Options.UseForeColor = true;
            this.tvSchedule.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.tvSchedule.Appearance.TreeLine.Options.UseBackColor = true;
            this.tvSchedule.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.tvSchedule.Appearance.VertLine.Options.UseBackColor = true;
            this.tvSchedule.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.cTeamA,
            this.cTeamB,
            this.treeListColumn6,
            this.treeListColumn7,
            this.treeListColumn8,
            this.treeListColumn9,
            this.treeListColumn10,
            this.cNum});
            this.tvSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSchedule.KeyFieldName = "GUID";
            this.tvSchedule.Location = new System.Drawing.Point(0, 71);
            this.tvSchedule.Name = "tvSchedule";
            this.tvSchedule.OptionsBehavior.PopulateServiceColumns = true;
            this.tvSchedule.OptionsView.EnableAppearanceEvenRow = true;
            this.tvSchedule.OptionsView.EnableAppearanceOddRow = true;
            this.tvSchedule.ParentFieldName = "PGUID";
            this.tvSchedule.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rbState,
            this.lueArea,
            this.lueGymnasium,
            this.lueTeamA,
            this.lueTeamB,
            this.dtGameTime,
            this.dtGameDate,
            this.btDelete});
            this.tvSchedule.RootValue = "-1";
            this.tvSchedule.Size = new System.Drawing.Size(850, 262);
            this.tvSchedule.TabIndex = 4;
            this.tvSchedule.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tvSchedule_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "名      称";
            this.treeListColumn1.FieldName = "NAME";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 2;
            this.treeListColumn1.Width = 111;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "比赛日期";
            this.treeListColumn2.ColumnEdit = this.dtGameDate;
            this.treeListColumn2.FieldName = "GAMEDATE";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            this.treeListColumn2.Width = 100;
            // 
            // dtGameDate
            // 
            this.dtGameDate.AutoHeight = false;
            this.dtGameDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtGameDate.Name = "dtGameDate";
            this.dtGameDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "比赛时间";
            this.treeListColumn3.ColumnEdit = this.dtGameTime;
            this.treeListColumn3.FieldName = "GAMETIME";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 1;
            this.treeListColumn3.Width = 81;
            // 
            // dtGameTime
            // 
            this.dtGameTime.AutoHeight = false;
            this.dtGameTime.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtGameTime.Name = "dtGameTime";
            // 
            // cTeamA
            // 
            this.cTeamA.Caption = "主      队";
            this.cTeamA.ColumnEdit = this.lueTeamA;
            this.cTeamA.FieldName = "TEAMAGUID";
            this.cTeamA.Name = "cTeamA";
            this.cTeamA.Visible = true;
            this.cTeamA.VisibleIndex = 4;
            this.cTeamA.Width = 76;
            // 
            // lueTeamA
            // 
            this.lueTeamA.AutoHeight = false;
            this.lueTeamA.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTeamA.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "名    称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SHORTNAME", "简    称")});
            this.lueTeamA.DisplayMember = "NAME";
            this.lueTeamA.Name = "lueTeamA";
            this.lueTeamA.ValueMember = "GUID";
            this.lueTeamA.EditValueChanged += new System.EventHandler(this.lueTeamA_EditValueChanged);
            // 
            // cTeamB
            // 
            this.cTeamB.Caption = "客      队";
            this.cTeamB.ColumnEdit = this.lueTeamB;
            this.cTeamB.FieldName = "TEAMBGUID";
            this.cTeamB.Name = "cTeamB";
            this.cTeamB.Visible = true;
            this.cTeamB.VisibleIndex = 5;
            this.cTeamB.Width = 76;
            // 
            // lueTeamB
            // 
            this.lueTeamB.AutoHeight = false;
            this.lueTeamB.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTeamB.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "名    称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SHORTNAME", "简    称")});
            this.lueTeamB.DisplayMember = "NAME";
            this.lueTeamB.Name = "lueTeamB";
            this.lueTeamB.ValueMember = "GUID";
            this.lueTeamB.EditValueChanged += new System.EventHandler(this.lueTeamB_EditValueChanged);
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "比赛场馆";
            this.treeListColumn6.ColumnEdit = this.lueGymnasium;
            this.treeListColumn6.FieldName = "GYMNASIUMGUID";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 6;
            this.treeListColumn6.Width = 77;
            // 
            // lueGymnasium
            // 
            this.lueGymnasium.AutoHeight = false;
            this.lueGymnasium.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGymnasium.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "名    称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IPADDRESS", "IP地址"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PORT", "端口号")});
            this.lueGymnasium.DisplayMember = "NAME";
            this.lueGymnasium.Name = "lueGymnasium";
            this.lueGymnasium.ValueMember = "GUID";
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "区      域";
            this.treeListColumn7.ColumnEdit = this.lueArea;
            this.treeListColumn7.FieldName = "AREAGUID";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 7;
            this.treeListColumn7.Width = 77;
            // 
            // lueArea
            // 
            this.lueArea.AutoHeight = false;
            this.lueArea.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueArea.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "名    称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IPADDRESS", "IP地址"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PORT", "端口号")});
            this.lueArea.DisplayMember = "NAME";
            this.lueArea.Name = "lueArea";
            this.lueArea.ValueMember = "GUID";
            // 
            // treeListColumn8
            // 
            this.treeListColumn8.Caption = "状      态";
            this.treeListColumn8.ColumnEdit = this.rbState;
            this.treeListColumn8.FieldName = "STATE";
            this.treeListColumn8.Name = "treeListColumn8";
            this.treeListColumn8.Visible = true;
            this.treeListColumn8.VisibleIndex = 8;
            this.treeListColumn8.Width = 77;
            // 
            // rbState
            // 
            this.rbState.AutoHeight = false;
            this.rbState.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rbState.Items.AddRange(new object[] {
            "未开始",
            "进行中",
            "已结束"});
            this.rbState.Name = "rbState";
            this.rbState.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // treeListColumn9
            // 
            this.treeListColumn9.Caption = "备      注";
            this.treeListColumn9.FieldName = "MEMO";
            this.treeListColumn9.Name = "treeListColumn9";
            this.treeListColumn9.Visible = true;
            this.treeListColumn9.VisibleIndex = 9;
            this.treeListColumn9.Width = 97;
            // 
            // treeListColumn10
            // 
            this.treeListColumn10.ColumnEdit = this.btDelete;
            this.treeListColumn10.Name = "treeListColumn10";
            this.treeListColumn10.Visible = true;
            this.treeListColumn10.VisibleIndex = 10;
            this.treeListColumn10.Width = 57;
            // 
            // btDelete
            // 
            this.btDelete.AutoHeight = false;
            this.btDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btDelete.Name = "btDelete";
            this.btDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btDelete_ButtonClick);
            // 
            // cNum
            // 
            this.cNum.Caption = "场      次";
            this.cNum.FieldName = "NUM";
            this.cNum.Name = "cNum";
            this.cNum.Visible = true;
            this.cNum.VisibleIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 176);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参赛队员";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(844, 156);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gcTeamB);
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(425, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 150);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "客队人员";
            // 
            // gcTeamB
            // 
            this.gcTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTeamB.Location = new System.Drawing.Point(3, 46);
            this.gcTeamB.MainView = this.gvTeamB;
            this.gcTeamB.Name = "gcTeamB";
            this.gcTeamB.Size = new System.Drawing.Size(410, 101);
            this.gcTeamB.TabIndex = 18;
            this.gcTeamB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTeamB});
            // 
            // gvTeamB
            // 
            this.gvTeamB.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvTeamB.GridControl = this.gcTeamB;
            this.gvTeamB.Name = "gvTeamB";
            this.gvTeamB.OptionsBehavior.Editable = false;
            this.gvTeamB.OptionsView.ShowGroupPanel = false;
            this.gvTeamB.OptionsView.ShowIndicator = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "姓      名";
            this.gridColumn4.FieldName = "ATHLETESNAME";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "性      别";
            this.gridColumn5.FieldName = "SEX";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "号      码";
            this.gridColumn6.FieldName = "BIBNUM";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btAddTeamBAthletes, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btDeleteTeamBAthletes, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(410, 29);
            this.tableLayoutPanel4.TabIndex = 16;
            // 
            // btAddTeamBAthletes
            // 
            this.btAddTeamBAthletes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddTeamBAthletes.EnglishText = null;
            this.btAddTeamBAthletes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAddTeamBAthletes.FOCUSFONT = null;
            this.btAddTeamBAthletes.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btAddTeamBAthletes.Location = new System.Drawing.Point(3, 3);
            this.btAddTeamBAthletes.Name = "btAddTeamBAthletes";
            this.btAddTeamBAthletes.Size = new System.Drawing.Size(94, 23);
            this.btAddTeamBAthletes.TabIndex = 22;
            this.btAddTeamBAthletes.Text = "增加";
            this.btAddTeamBAthletes.UNFOCUSFONT = null;
            this.btAddTeamBAthletes.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btAddTeamBAthletes.UseVisualStyleBackColor = true;
            this.btAddTeamBAthletes.Click += new System.EventHandler(this.btAddTeamBAthletes_Click);
            // 
            // btDeleteTeamBAthletes
            // 
            this.btDeleteTeamBAthletes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteTeamBAthletes.EnglishText = null;
            this.btDeleteTeamBAthletes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDeleteTeamBAthletes.FOCUSFONT = null;
            this.btDeleteTeamBAthletes.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btDeleteTeamBAthletes.Location = new System.Drawing.Point(103, 3);
            this.btDeleteTeamBAthletes.Name = "btDeleteTeamBAthletes";
            this.btDeleteTeamBAthletes.Size = new System.Drawing.Size(94, 23);
            this.btDeleteTeamBAthletes.TabIndex = 23;
            this.btDeleteTeamBAthletes.Text = "删除";
            this.btDeleteTeamBAthletes.UNFOCUSFONT = null;
            this.btDeleteTeamBAthletes.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btDeleteTeamBAthletes.UseVisualStyleBackColor = true;
            this.btDeleteTeamBAthletes.Click += new System.EventHandler(this.btDeleteTeamBAthletes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gcTeamA);
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 150);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "主队人员";
            // 
            // gcTeamA
            // 
            this.gcTeamA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTeamA.Location = new System.Drawing.Point(3, 46);
            this.gcTeamA.MainView = this.gvTeamA;
            this.gcTeamA.Name = "gcTeamA";
            this.gcTeamA.Size = new System.Drawing.Size(410, 101);
            this.gcTeamA.TabIndex = 17;
            this.gcTeamA.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTeamA});
            // 
            // gvTeamA
            // 
            this.gvTeamA.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvTeamA.GridControl = this.gcTeamA;
            this.gvTeamA.Name = "gvTeamA";
            this.gvTeamA.OptionsBehavior.Editable = false;
            this.gvTeamA.OptionsView.ShowGroupPanel = false;
            this.gvTeamA.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "姓      名";
            this.gridColumn1.FieldName = "ATHLETESNAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "性      别";
            this.gridColumn2.FieldName = "SEX";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "号      码";
            this.gridColumn3.FieldName = "BIBNUM";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btAddTeamAAthletes, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btDeleteTeamAAthletes, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(410, 29);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // btAddTeamAAthletes
            // 
            this.btAddTeamAAthletes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddTeamAAthletes.EnglishText = null;
            this.btAddTeamAAthletes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAddTeamAAthletes.FOCUSFONT = null;
            this.btAddTeamAAthletes.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btAddTeamAAthletes.Location = new System.Drawing.Point(3, 3);
            this.btAddTeamAAthletes.Name = "btAddTeamAAthletes";
            this.btAddTeamAAthletes.Size = new System.Drawing.Size(94, 23);
            this.btAddTeamAAthletes.TabIndex = 22;
            this.btAddTeamAAthletes.Text = "增加";
            this.btAddTeamAAthletes.UNFOCUSFONT = null;
            this.btAddTeamAAthletes.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btAddTeamAAthletes.UseVisualStyleBackColor = true;
            this.btAddTeamAAthletes.Click += new System.EventHandler(this.btAddTeamAAthletes_Click);
            // 
            // btDeleteTeamAAthletes
            // 
            this.btDeleteTeamAAthletes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteTeamAAthletes.EnglishText = null;
            this.btDeleteTeamAAthletes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDeleteTeamAAthletes.FOCUSFONT = null;
            this.btDeleteTeamAAthletes.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btDeleteTeamAAthletes.Location = new System.Drawing.Point(103, 3);
            this.btDeleteTeamAAthletes.Name = "btDeleteTeamAAthletes";
            this.btDeleteTeamAAthletes.Size = new System.Drawing.Size(94, 23);
            this.btDeleteTeamAAthletes.TabIndex = 23;
            this.btDeleteTeamAAthletes.Text = "删除";
            this.btDeleteTeamAAthletes.UNFOCUSFONT = null;
            this.btDeleteTeamAAthletes.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btDeleteTeamAAthletes.UseVisualStyleBackColor = true;
            this.btDeleteTeamAAthletes.Click += new System.EventHandler(this.btDeleteTeamAAthletes_Click);
            // 
            // TeamSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tvSchedule);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.plButtons);
            this.Name = "TeamSchedule";
            this.Size = new System.Drawing.Size(850, 509);
            this.plButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGameDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGameDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGameTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTeamA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTeamB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGymnasium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTeamB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTeamB)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTeamA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTeamA)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ApplicationControlCommon.MyButton btAdd;
        private ApplicationControlCommon.MyButton btAddChild;
        private ApplicationControlCommon.MyButton btRefresh;
        private ApplicationControlCommon.MyButton btSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup rbType;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cbImages;
        private DevExpress.XtraTreeList.TreeList tvSchedule;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn cTeamA;
        private DevExpress.XtraTreeList.Columns.TreeListColumn cTeamB;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dtGameDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit dtGameTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueTeamA;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueTeamB;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueGymnasium;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueArea;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rbState;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn9;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn10;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btDelete;
        private DevExpress.XtraTreeList.Columns.TreeListColumn cNum;
        private ApplicationControlCommon.MyButton btExpand;
        private ApplicationControlCommon.MyButton btCollapse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gcTeamB;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTeamB;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private ApplicationControlCommon.MyButton btAddTeamBAthletes;
        private ApplicationControlCommon.MyButton btDeleteTeamBAthletes;
        private DevExpress.XtraGrid.GridControl gcTeamA;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTeamA;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ApplicationControlCommon.MyButton btAddTeamAAthletes;
        private ApplicationControlCommon.MyButton btDeleteTeamAAthletes;
    }
}
