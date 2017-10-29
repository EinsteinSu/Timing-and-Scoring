namespace SystemManager
{
    partial class UserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManager));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btSave = new ApplicationControlCommon.MyButton();
            this.btAdd = new ApplicationControlCommon.MyButton();
            this.btRefresh = new ApplicationControlCommon.MyButton();
            this.plButtons = new System.Windows.Forms.Panel();
            this.gcUsers = new DevExpress.XtraGrid.GridControl();
            this.gvUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbPassWord = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbRoles = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rbMemo = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tableLayoutPanel1.SuspendLayout();
            this.plButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPassWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).BeginInit();
            this.SuspendLayout();
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
            // plButtons
            // 
            this.plButtons.Controls.Add(this.tableLayoutPanel1);
            this.plButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.plButtons.Location = new System.Drawing.Point(0, 0);
            this.plButtons.Name = "plButtons";
            this.plButtons.Size = new System.Drawing.Size(741, 71);
            this.plButtons.TabIndex = 1;
            // 
            // gcUsers
            // 
            this.gcUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUsers.Location = new System.Drawing.Point(0, 71);
            this.gcUsers.MainView = this.gvUsers;
            this.gcUsers.Name = "gcUsers";
            this.gcUsers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.tbPassWord,
            this.rbMemo,
            this.cbRoles,
            this.btDelete});
            this.gcUsers.Size = new System.Drawing.Size(741, 428);
            this.gcUsers.TabIndex = 2;
            this.gcUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUsers});
            // 
            // gvUsers
            // 
            this.gvUsers.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gvUsers.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvUsers.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gvUsers.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gvUsers.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvUsers.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvUsers.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvUsers.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvUsers.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvUsers.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvUsers.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gvUsers.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvUsers.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvUsers.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvUsers.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gvUsers.Appearance.Empty.Options.UseBackColor = true;
            this.gvUsers.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvUsers.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gvUsers.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvUsers.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvUsers.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvUsers.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvUsers.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvUsers.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gvUsers.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvUsers.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvUsers.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvUsers.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvUsers.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvUsers.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvUsers.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gvUsers.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvUsers.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvUsers.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvUsers.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvUsers.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvUsers.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gvUsers.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvUsers.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gvUsers.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvUsers.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvUsers.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvUsers.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy;
            this.gvUsers.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gvUsers.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvUsers.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvUsers.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvUsers.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gvUsers.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvUsers.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvUsers.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvUsers.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvUsers.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvUsers.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gvUsers.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gvUsers.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvUsers.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvUsers.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvUsers.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvUsers.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvUsers.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvUsers.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvUsers.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvUsers.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvUsers.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvUsers.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gvUsers.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvUsers.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvUsers.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gvUsers.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvUsers.Appearance.GroupPanel.Options.UseFont = true;
            this.gvUsers.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvUsers.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gvUsers.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gvUsers.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvUsers.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvUsers.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvUsers.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvUsers.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvUsers.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvUsers.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvUsers.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvUsers.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvUsers.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvUsers.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gvUsers.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvUsers.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvUsers.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvUsers.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gvUsers.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvUsers.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvUsers.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gvUsers.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvUsers.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gvUsers.Appearance.OddRow.Options.UseBackColor = true;
            this.gvUsers.Appearance.OddRow.Options.UseForeColor = true;
            this.gvUsers.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gvUsers.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gvUsers.Appearance.Preview.Options.UseBackColor = true;
            this.gvUsers.Appearance.Preview.Options.UseForeColor = true;
            this.gvUsers.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvUsers.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvUsers.Appearance.Row.Options.UseBackColor = true;
            this.gvUsers.Appearance.Row.Options.UseForeColor = true;
            this.gvUsers.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvUsers.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gvUsers.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvUsers.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gvUsers.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvUsers.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvUsers.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvUsers.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gvUsers.Appearance.VertLine.Options.UseBackColor = true;
            this.gvUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvUsers.GridControl = this.gcUsers;
            this.gvUsers.Name = "gvUsers";
            this.gvUsers.OptionsNavigation.AutoFocusNewRow = true;
            this.gvUsers.OptionsView.ColumnAutoWidth = false;
            this.gvUsers.OptionsView.EnableAppearanceEvenRow = true;
            this.gvUsers.OptionsView.EnableAppearanceOddRow = true;
            this.gvUsers.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "用户名";
            this.gridColumn1.FieldName = "USERNAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 117;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "密码";
            this.gridColumn2.ColumnEdit = this.tbPassWord;
            this.gridColumn2.FieldName = "PASSWORD";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 160;
            // 
            // tbPassWord
            // 
            this.tbPassWord.AutoHeight = false;
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.PasswordChar = '*';
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "权限";
            this.gridColumn3.ColumnEdit = this.cbRoles;
            this.gridColumn3.FieldName = "ROLEGUIDS";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 179;
            // 
            // cbRoles
            // 
            this.cbRoles.AutoHeight = false;
            this.cbRoles.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "备注";
            this.gridColumn4.ColumnEdit = this.rbMemo;
            this.gridColumn4.FieldName = "REMARKS";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
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
            this.gridColumn5.VisibleIndex = 4;
            // 
            // btDelete
            // 
            this.btDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btDelete.Name = "btDelete";
            this.btDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btDelete_ButtonClick);
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcUsers);
            this.Controls.Add(this.plButtons);
            this.Name = "UserManager";
            this.Size = new System.Drawing.Size(741, 499);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.plButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPassWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ApplicationControlCommon.MyButton btRefresh;
        private System.Windows.Forms.Panel plButtons;
        private ApplicationControlCommon.MyButton btSave;
        private ApplicationControlCommon.MyButton btAdd;
        private DevExpress.XtraGrid.GridControl gcUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUsers;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit tbPassWord;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit rbMemo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit cbRoles;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btDelete;
    }
}
