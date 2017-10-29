namespace AthleticsParamManager
{
    partial class ParamsManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParamsManager));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.plButtons = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btSave = new ApplicationControlCommon.MyButton();
            this.btAdd = new ApplicationControlCommon.MyButton();
            this.btRefresh = new ApplicationControlCommon.MyButton();
            this.gcParams = new DevExpress.XtraGrid.GridControl();
            this.gvParamers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rbMemo = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.plButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcParams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvParamers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // plButtons
            // 
            this.plButtons.Controls.Add(this.tableLayoutPanel1);
            this.plButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.plButtons.Location = new System.Drawing.Point(0, 0);
            this.plButtons.Name = "plButtons";
            this.plButtons.Size = new System.Drawing.Size(638, 71);
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
            this.tableLayoutPanel1.Controls.Add(this.btSave, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btAdd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btRefresh, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 71);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.btSave.Location = new System.Drawing.Point(183, 3);
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
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "增加";
            this.btAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdd.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
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
            // gcParams
            // 
            this.gcParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcParams.Location = new System.Drawing.Point(0, 71);
            this.gcParams.MainView = this.gvParamers;
            this.gcParams.Name = "gcParams";
            this.gcParams.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rbMemo,
            this.btDelete});
            this.gcParams.Size = new System.Drawing.Size(638, 414);
            this.gcParams.TabIndex = 4;
            this.gcParams.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvParamers,
            this.gv});
            // 
            // gvParamers
            // 
            this.gvParamers.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gvParamers.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvParamers.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gvParamers.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gvParamers.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvParamers.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvParamers.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvParamers.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvParamers.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvParamers.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvParamers.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gvParamers.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvParamers.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvParamers.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvParamers.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gvParamers.Appearance.Empty.Options.UseBackColor = true;
            this.gvParamers.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvParamers.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gvParamers.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvParamers.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvParamers.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvParamers.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvParamers.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvParamers.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gvParamers.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvParamers.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvParamers.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvParamers.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvParamers.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvParamers.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvParamers.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gvParamers.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvParamers.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvParamers.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvParamers.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvParamers.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvParamers.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gvParamers.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvParamers.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gvParamers.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvParamers.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvParamers.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvParamers.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy;
            this.gvParamers.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gvParamers.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvParamers.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvParamers.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvParamers.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gvParamers.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvParamers.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvParamers.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvParamers.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvParamers.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvParamers.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gvParamers.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gvParamers.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvParamers.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvParamers.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvParamers.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvParamers.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvParamers.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvParamers.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvParamers.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvParamers.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvParamers.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvParamers.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gvParamers.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvParamers.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvParamers.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gvParamers.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvParamers.Appearance.GroupPanel.Options.UseFont = true;
            this.gvParamers.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvParamers.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gvParamers.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gvParamers.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvParamers.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvParamers.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvParamers.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvParamers.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvParamers.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvParamers.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvParamers.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvParamers.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvParamers.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvParamers.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gvParamers.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvParamers.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvParamers.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvParamers.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gvParamers.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvParamers.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvParamers.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gvParamers.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvParamers.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gvParamers.Appearance.OddRow.Options.UseBackColor = true;
            this.gvParamers.Appearance.OddRow.Options.UseForeColor = true;
            this.gvParamers.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gvParamers.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gvParamers.Appearance.Preview.Options.UseBackColor = true;
            this.gvParamers.Appearance.Preview.Options.UseForeColor = true;
            this.gvParamers.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvParamers.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvParamers.Appearance.Row.Options.UseBackColor = true;
            this.gvParamers.Appearance.Row.Options.UseForeColor = true;
            this.gvParamers.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvParamers.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gvParamers.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvParamers.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gvParamers.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvParamers.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvParamers.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvParamers.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gvParamers.Appearance.VertLine.Options.UseBackColor = true;
            this.gvParamers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn6});
            this.gvParamers.GridControl = this.gcParams;
            this.gvParamers.Name = "gvParamers";
            this.gvParamers.OptionsNavigation.AutoFocusNewRow = true;
            this.gvParamers.OptionsView.ColumnAutoWidth = false;
            this.gvParamers.OptionsView.EnableAppearanceEvenRow = true;
            this.gvParamers.OptionsView.EnableAppearanceOddRow = true;
            this.gvParamers.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "备    注";
            this.gridColumn4.ColumnEdit = this.rbMemo;
            this.gridColumn4.FieldName = "MEMO";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 160;
            // 
            // rbMemo
            // 
            this.rbMemo.AutoHeight = false;
            this.rbMemo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rbMemo.Name = "rbMemo";
            // 
            // gridColumn5
            // 
            this.gridColumn5.ColumnEdit = this.btDelete;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // btDelete
            // 
            this.btDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btDelete.Name = "btDelete";
            this.btDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btDelete_ButtonClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "参数分类";
            this.gridColumn1.FieldName = "CLASS";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 130;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "参数名称";
            this.gridColumn2.FieldName = "NAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 120;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "参数属性";
            this.gridColumn3.FieldName = "ATTRIBUTE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 146;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "排序编号";
            this.gridColumn6.FieldName = "ORDERID";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 133;
            // 
            // gv
            // 
            this.gv.GridControl = this.gcParams;
            this.gv.Name = "gv";
            // 
            // ParamsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcParams);
            this.Controls.Add(this.plButtons);
            this.Name = "ParamsManager";
            this.Size = new System.Drawing.Size(638, 485);
            this.plButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcParams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvParamers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ApplicationControlCommon.MyButton btSave;
        private ApplicationControlCommon.MyButton btAdd;
        private ApplicationControlCommon.MyButton btRefresh;
        private DevExpress.XtraGrid.GridControl gcParams;
        private DevExpress.XtraGrid.Views.Grid.GridView gvParamers;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit rbMemo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Views.Grid.GridView gv;
    }
}
