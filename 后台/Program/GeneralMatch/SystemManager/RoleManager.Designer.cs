namespace SystemManager
{
    partial class RoleManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleManager));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.plButtons = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btSave = new ApplicationControlCommon.MyButton();
            this.btAdd = new ApplicationControlCommon.MyButton();
            this.btRefresh = new ApplicationControlCommon.MyButton();
            this.btAll = new ApplicationControlCommon.MyButton();
            this.btAdverse = new ApplicationControlCommon.MyButton();
            this.btNone = new ApplicationControlCommon.MyButton();
            this.gcRole = new DevExpress.XtraGrid.GridControl();
            this.gvRole = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rbMemo = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treeFunction = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.cbHave = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.plButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHave)).BeginInit();
            this.SuspendLayout();
            // 
            // plButtons
            // 
            this.plButtons.Controls.Add(this.tableLayoutPanel1);
            this.plButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.plButtons.Location = new System.Drawing.Point(0, 0);
            this.plButtons.Name = "plButtons";
            this.plButtons.Size = new System.Drawing.Size(795, 71);
            this.plButtons.TabIndex = 2;
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
            this.tableLayoutPanel1.Controls.Add(this.btAll, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btAdverse, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btNone, 6, 0);
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
            // btAll
            // 
            this.btAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btAll.EnglishText = null;
            this.btAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAll.FOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAll.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btAll.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAll.Image = ((System.Drawing.Image)(resources.GetObject("btAll.Image")));
            this.btAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAll.Location = new System.Drawing.Point(363, 3);
            this.btAll.Name = "btAll";
            this.btAll.Size = new System.Drawing.Size(84, 65);
            this.btAll.TabIndex = 3;
            this.btAll.Text = "全选";
            this.btAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAll.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAll.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btAll.UseVisualStyleBackColor = true;
            this.btAll.Click += new System.EventHandler(this.btAll_Click);
            // 
            // btAdverse
            // 
            this.btAdverse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdverse.EnglishText = null;
            this.btAdverse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdverse.FOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdverse.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btAdverse.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdverse.Image = ((System.Drawing.Image)(resources.GetObject("btAdverse.Image")));
            this.btAdverse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdverse.Location = new System.Drawing.Point(453, 3);
            this.btAdverse.Name = "btAdverse";
            this.btAdverse.Size = new System.Drawing.Size(84, 65);
            this.btAdverse.TabIndex = 4;
            this.btAdverse.Text = "反选";
            this.btAdverse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdverse.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdverse.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btAdverse.UseVisualStyleBackColor = true;
            this.btAdverse.Click += new System.EventHandler(this.btAdverse_Click);
            // 
            // btNone
            // 
            this.btNone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btNone.EnglishText = null;
            this.btNone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btNone.FOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btNone.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btNone.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btNone.Image = ((System.Drawing.Image)(resources.GetObject("btNone.Image")));
            this.btNone.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btNone.Location = new System.Drawing.Point(543, 3);
            this.btNone.Name = "btNone";
            this.btNone.Size = new System.Drawing.Size(84, 65);
            this.btNone.TabIndex = 5;
            this.btNone.Text = "不选";
            this.btNone.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btNone.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btNone.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btNone.UseVisualStyleBackColor = true;
            this.btNone.Click += new System.EventHandler(this.btNone_Click);
            // 
            // gcRole
            // 
            this.gcRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRole.Location = new System.Drawing.Point(3, 17);
            this.gcRole.MainView = this.gvRole;
            this.gcRole.Name = "gcRole";
            this.gcRole.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rbMemo,
            this.btDelete});
            this.gcRole.Size = new System.Drawing.Size(261, 422);
            this.gcRole.TabIndex = 3;
            this.gcRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRole});
            // 
            // gvRole
            // 
            this.gvRole.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gvRole.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvRole.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gvRole.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gvRole.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvRole.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvRole.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvRole.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvRole.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvRole.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvRole.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gvRole.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvRole.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvRole.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvRole.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gvRole.Appearance.Empty.Options.UseBackColor = true;
            this.gvRole.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvRole.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gvRole.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvRole.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvRole.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvRole.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvRole.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvRole.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gvRole.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvRole.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvRole.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvRole.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvRole.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvRole.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvRole.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gvRole.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvRole.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvRole.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvRole.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvRole.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvRole.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gvRole.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvRole.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gvRole.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvRole.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvRole.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvRole.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy;
            this.gvRole.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gvRole.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvRole.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvRole.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvRole.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gvRole.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvRole.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRole.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvRole.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvRole.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvRole.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gvRole.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gvRole.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvRole.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvRole.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvRole.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvRole.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvRole.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvRole.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvRole.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvRole.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvRole.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvRole.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gvRole.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvRole.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvRole.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gvRole.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvRole.Appearance.GroupPanel.Options.UseFont = true;
            this.gvRole.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvRole.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gvRole.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gvRole.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvRole.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvRole.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvRole.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvRole.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvRole.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRole.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvRole.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvRole.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvRole.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvRole.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gvRole.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvRole.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvRole.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvRole.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gvRole.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvRole.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvRole.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gvRole.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvRole.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gvRole.Appearance.OddRow.Options.UseBackColor = true;
            this.gvRole.Appearance.OddRow.Options.UseForeColor = true;
            this.gvRole.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gvRole.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gvRole.Appearance.Preview.Options.UseBackColor = true;
            this.gvRole.Appearance.Preview.Options.UseForeColor = true;
            this.gvRole.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvRole.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvRole.Appearance.Row.Options.UseBackColor = true;
            this.gvRole.Appearance.Row.Options.UseForeColor = true;
            this.gvRole.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvRole.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gvRole.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvRole.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gvRole.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvRole.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvRole.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvRole.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gvRole.Appearance.VertLine.Options.UseBackColor = true;
            this.gvRole.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn5});
            this.gvRole.GridControl = this.gcRole;
            this.gvRole.Name = "gvRole";
            this.gvRole.OptionsNavigation.AutoFocusNewRow = true;
            this.gvRole.OptionsView.EnableAppearanceEvenRow = true;
            this.gvRole.OptionsView.EnableAppearanceOddRow = true;
            this.gvRole.OptionsView.ShowGroupPanel = false;
            this.gvRole.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvRole_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "用户名";
            this.gridColumn1.FieldName = "NAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "备注";
            this.gridColumn4.ColumnEdit = this.rbMemo;
            this.gridColumn4.FieldName = "REMARKS";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
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
            this.gridColumn5.VisibleIndex = 2;
            // 
            // btDelete
            // 
            this.btDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btDelete.Name = "btDelete";
            this.btDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btDelete_ButtonClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gcRole);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 442);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "角色";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treeFunction);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(267, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 442);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "权限";
            // 
            // treeFunction
            // 
            this.treeFunction.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.treeFunction.Appearance.Empty.Options.UseBackColor = true;
            this.treeFunction.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.treeFunction.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.treeFunction.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.treeFunction.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.treeFunction.Appearance.EvenRow.Options.UseBackColor = true;
            this.treeFunction.Appearance.EvenRow.Options.UseForeColor = true;
            this.treeFunction.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.treeFunction.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.treeFunction.Appearance.FocusedCell.Options.UseBackColor = true;
            this.treeFunction.Appearance.FocusedCell.Options.UseForeColor = true;
            this.treeFunction.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy;
            this.treeFunction.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.treeFunction.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.treeFunction.Appearance.FocusedRow.Options.UseBackColor = true;
            this.treeFunction.Appearance.FocusedRow.Options.UseForeColor = true;
            this.treeFunction.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.treeFunction.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.treeFunction.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.treeFunction.Appearance.FooterPanel.Options.UseBackColor = true;
            this.treeFunction.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.treeFunction.Appearance.FooterPanel.Options.UseForeColor = true;
            this.treeFunction.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.treeFunction.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.treeFunction.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.treeFunction.Appearance.GroupButton.Options.UseBackColor = true;
            this.treeFunction.Appearance.GroupButton.Options.UseBorderColor = true;
            this.treeFunction.Appearance.GroupButton.Options.UseForeColor = true;
            this.treeFunction.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.treeFunction.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.treeFunction.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.treeFunction.Appearance.GroupFooter.Options.UseBackColor = true;
            this.treeFunction.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.treeFunction.Appearance.GroupFooter.Options.UseForeColor = true;
            this.treeFunction.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.treeFunction.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.treeFunction.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.treeFunction.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.treeFunction.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.treeFunction.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.treeFunction.Appearance.HeaderPanel.Options.UseFont = true;
            this.treeFunction.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.treeFunction.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.treeFunction.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.treeFunction.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.treeFunction.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.treeFunction.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.treeFunction.Appearance.HorzLine.Options.UseBackColor = true;
            this.treeFunction.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.treeFunction.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.treeFunction.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.treeFunction.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.treeFunction.Appearance.OddRow.Options.UseBackColor = true;
            this.treeFunction.Appearance.OddRow.Options.UseForeColor = true;
            this.treeFunction.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.treeFunction.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.treeFunction.Appearance.Preview.Options.UseBackColor = true;
            this.treeFunction.Appearance.Preview.Options.UseForeColor = true;
            this.treeFunction.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.treeFunction.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.treeFunction.Appearance.Row.Options.UseBackColor = true;
            this.treeFunction.Appearance.Row.Options.UseForeColor = true;
            this.treeFunction.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.treeFunction.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.treeFunction.Appearance.SelectedRow.Options.UseBackColor = true;
            this.treeFunction.Appearance.SelectedRow.Options.UseForeColor = true;
            this.treeFunction.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.treeFunction.Appearance.TreeLine.Options.UseBackColor = true;
            this.treeFunction.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.treeFunction.Appearance.VertLine.Options.UseBackColor = true;
            this.treeFunction.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.treeFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeFunction.KeyFieldName = "FGUID";
            this.treeFunction.Location = new System.Drawing.Point(3, 17);
            this.treeFunction.Name = "treeFunction";
            this.treeFunction.OptionsBehavior.PopulateServiceColumns = true;
            this.treeFunction.OptionsView.AutoWidth = false;
            this.treeFunction.OptionsView.EnableAppearanceEvenRow = true;
            this.treeFunction.OptionsView.EnableAppearanceOddRow = true;
            this.treeFunction.ParentFieldName = "FPGUID";
            this.treeFunction.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbHave});
            this.treeFunction.Size = new System.Drawing.Size(522, 422);
            this.treeFunction.TabIndex = 4;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "名称";
            this.treeListColumn1.FieldName = "NAME";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 194;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "有无权限";
            this.treeListColumn2.ColumnEdit = this.cbHave;
            this.treeListColumn2.FieldName = "ISHAVE";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // cbHave
            // 
            this.cbHave.AutoHeight = false;
            this.cbHave.Name = "cbHave";
            this.cbHave.ValueChecked = 1;
            this.cbHave.ValueUnchecked = 0;
            // 
            // RoleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.plButtons);
            this.Name = "RoleManager";
            this.Size = new System.Drawing.Size(795, 513);
            this.plButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ApplicationControlCommon.MyButton btSave;
        private ApplicationControlCommon.MyButton btAdd;
        private ApplicationControlCommon.MyButton btRefresh;
        private DevExpress.XtraGrid.GridControl gcRole;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRole;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit rbMemo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraTreeList.TreeList treeFunction;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit cbHave;
        private ApplicationControlCommon.MyButton btAll;
        private ApplicationControlCommon.MyButton btAdverse;
        private ApplicationControlCommon.MyButton btNone;
    }
}
