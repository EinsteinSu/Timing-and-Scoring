namespace ScheduleManager
{
    partial class ScheduleView
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
            DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
            DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
            DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleView));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
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
            this.cNum = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.plButtons = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btRefresh = new ApplicationControlCommon.MyButton();
            this.btExpand = new ApplicationControlCommon.MyButton();
            this.btCollapse = new ApplicationControlCommon.MyButton();
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
            this.plButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.cNum,
            this.treeListColumn4,
            this.treeListColumn5});
            this.tvSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "[STATE] == \'已结束\'";
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Yellow;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition2.Expression = "[STATE] == \'进行中\'";
            styleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Lime;
            styleFormatCondition3.Appearance.Options.UseBackColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition3.Expression = "[STATE] == \'未开始\'";
            this.tvSchedule.FormatConditions.AddRange(new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3});
            this.tvSchedule.KeyFieldName = "GUID";
            this.tvSchedule.Location = new System.Drawing.Point(0, 71);
            this.tvSchedule.Name = "tvSchedule";
            this.tvSchedule.OptionsBehavior.Editable = false;
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
            this.tvSchedule.Size = new System.Drawing.Size(769, 410);
            this.tvSchedule.TabIndex = 5;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "名      称";
            this.treeListColumn1.FieldName = "NAME";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 2;
            this.treeListColumn1.Width = 95;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "比赛日期";
            this.treeListColumn2.ColumnEdit = this.dtGameDate;
            this.treeListColumn2.FieldName = "GAMEDATE";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            this.treeListColumn2.Width = 103;
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
            this.treeListColumn3.Width = 103;
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
            this.cTeamA.Width = 95;
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
            // 
            // cTeamB
            // 
            this.cTeamB.Caption = "客      队";
            this.cTeamB.ColumnEdit = this.lueTeamB;
            this.cTeamB.FieldName = "TEAMBGUID";
            this.cTeamB.Name = "cTeamB";
            this.cTeamB.Visible = true;
            this.cTeamB.VisibleIndex = 6;
            this.cTeamB.Width = 95;
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
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "比赛场馆";
            this.treeListColumn6.ColumnEdit = this.lueGymnasium;
            this.treeListColumn6.FieldName = "GYMNASIUMGUID";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 8;
            this.treeListColumn6.Width = 102;
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
            this.treeListColumn7.VisibleIndex = 9;
            this.treeListColumn7.Width = 94;
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
            this.treeListColumn8.VisibleIndex = 10;
            this.treeListColumn8.Width = 94;
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
            this.treeListColumn9.VisibleIndex = 11;
            this.treeListColumn9.Width = 94;
            // 
            // cNum
            // 
            this.cNum.Caption = "场      次";
            this.cNum.FieldName = "NUM";
            this.cNum.Name = "cNum";
            this.cNum.Visible = true;
            this.cNum.VisibleIndex = 3;
            this.cNum.Width = 95;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "主队比分";
            this.treeListColumn4.FieldName = "TEAMASCORE";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 5;
            this.treeListColumn4.Width = 103;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "客队比分";
            this.treeListColumn5.FieldName = "TEAMBSCORE";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 7;
            this.treeListColumn5.Width = 103;
            // 
            // btDelete
            // 
            this.btDelete.AutoHeight = false;
            this.btDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btDelete.Name = "btDelete";
            this.btDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // plButtons
            // 
            this.plButtons.Controls.Add(this.tableLayoutPanel1);
            this.plButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.plButtons.Location = new System.Drawing.Point(0, 0);
            this.plButtons.Name = "plButtons";
            this.plButtons.Size = new System.Drawing.Size(769, 71);
            this.plButtons.TabIndex = 6;
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
            this.tableLayoutPanel1.Controls.Add(this.btRefresh, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btExpand, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btCollapse, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 71);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.btExpand.Location = new System.Drawing.Point(183, 3);
            this.btExpand.Name = "btExpand";
            this.btExpand.Size = new System.Drawing.Size(84, 65);
            this.btExpand.TabIndex = 5;
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
            this.btCollapse.Location = new System.Drawing.Point(273, 3);
            this.btCollapse.Name = "btCollapse";
            this.btCollapse.Size = new System.Drawing.Size(84, 65);
            this.btCollapse.TabIndex = 6;
            this.btCollapse.Text = "收缩";
            this.btCollapse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCollapse.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCollapse.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btCollapse.UseVisualStyleBackColor = true;
            this.btCollapse.Click += new System.EventHandler(this.btCollapse_Click);
            // 
            // ScheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tvSchedule);
            this.Controls.Add(this.plButtons);
            this.Name = "ScheduleView";
            this.Size = new System.Drawing.Size(769, 481);
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
            this.plButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList tvSchedule;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dtGameDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit dtGameTime;
        private DevExpress.XtraTreeList.Columns.TreeListColumn cTeamA;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueTeamA;
        private DevExpress.XtraTreeList.Columns.TreeListColumn cTeamB;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueTeamB;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueGymnasium;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueArea;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rbState;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn9;
        private DevExpress.XtraTreeList.Columns.TreeListColumn cNum;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btDelete;
        private System.Windows.Forms.Panel plButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ApplicationControlCommon.MyButton btRefresh;
        private ApplicationControlCommon.MyButton btExpand;
        private ApplicationControlCommon.MyButton btCollapse;
    }
}
