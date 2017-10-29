namespace SystemManager
{
    partial class FunctionImageManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctionImageManager));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.plButtons = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btSave = new ApplicationControlCommon.MyButton();
            this.btAdd = new ApplicationControlCommon.MyButton();
            this.btRefresh = new ApplicationControlCommon.MyButton();
            this.gcImages = new DevExpress.XtraGrid.GridControl();
            this.gvImages = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pbImage = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.tbPassWord = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.rbMemo = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.cbRoles = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.plButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPassWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // plButtons
            // 
            this.plButtons.Controls.Add(this.tableLayoutPanel1);
            this.plButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.plButtons.Location = new System.Drawing.Point(0, 0);
            this.plButtons.Name = "plButtons";
            this.plButtons.Size = new System.Drawing.Size(687, 71);
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
            // gcImages
            // 
            this.gcImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcImages.Location = new System.Drawing.Point(0, 71);
            this.gcImages.MainView = this.gvImages;
            this.gcImages.Name = "gcImages";
            this.gcImages.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.tbPassWord,
            this.rbMemo,
            this.cbRoles,
            this.btDelete,
            this.pbImage});
            this.gcImages.Size = new System.Drawing.Size(687, 425);
            this.gcImages.TabIndex = 4;
            this.gcImages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvImages});
            // 
            // gvImages
            // 
            this.gvImages.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gvImages.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvImages.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gvImages.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gvImages.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvImages.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvImages.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvImages.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvImages.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvImages.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvImages.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gvImages.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvImages.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvImages.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvImages.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gvImages.Appearance.Empty.Options.UseBackColor = true;
            this.gvImages.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvImages.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gvImages.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvImages.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvImages.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvImages.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvImages.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvImages.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gvImages.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvImages.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvImages.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvImages.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvImages.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvImages.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvImages.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gvImages.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvImages.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvImages.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvImages.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvImages.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvImages.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gvImages.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvImages.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gvImages.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvImages.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvImages.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvImages.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy;
            this.gvImages.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gvImages.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvImages.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvImages.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvImages.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gvImages.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvImages.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvImages.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvImages.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvImages.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvImages.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gvImages.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gvImages.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvImages.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvImages.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvImages.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvImages.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvImages.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvImages.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvImages.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvImages.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvImages.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvImages.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gvImages.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvImages.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvImages.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gvImages.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvImages.Appearance.GroupPanel.Options.UseFont = true;
            this.gvImages.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvImages.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gvImages.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gvImages.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvImages.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvImages.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvImages.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvImages.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvImages.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvImages.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvImages.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvImages.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvImages.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvImages.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gvImages.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvImages.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvImages.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvImages.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gvImages.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvImages.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvImages.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gvImages.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvImages.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gvImages.Appearance.OddRow.Options.UseBackColor = true;
            this.gvImages.Appearance.OddRow.Options.UseForeColor = true;
            this.gvImages.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gvImages.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gvImages.Appearance.Preview.Options.UseBackColor = true;
            this.gvImages.Appearance.Preview.Options.UseForeColor = true;
            this.gvImages.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvImages.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvImages.Appearance.Row.Options.UseBackColor = true;
            this.gvImages.Appearance.Row.Options.UseForeColor = true;
            this.gvImages.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvImages.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gvImages.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvImages.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gvImages.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvImages.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvImages.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvImages.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gvImages.Appearance.VertLine.Options.UseBackColor = true;
            this.gvImages.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn2});
            this.gvImages.GridControl = this.gcImages;
            this.gvImages.Name = "gvImages";
            this.gvImages.OptionsView.EnableAppearanceEvenRow = true;
            this.gvImages.OptionsView.EnableAppearanceOddRow = true;
            this.gvImages.OptionsView.ShowGroupPanel = false;
            this.gvImages.RowHeight = 32;
            // 
            // gridColumn5
            // 
            this.gridColumn5.ColumnEdit = this.btDelete;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
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
            // gridColumn1
            // 
            this.gridColumn1.Caption = "序号";
            this.gridColumn1.FieldName = "IMAGEINDEX";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "名称";
            this.gridColumn3.FieldName = "NAME";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "图片";
            this.gridColumn2.ColumnEdit = this.pbImage;
            this.gridColumn2.FieldName = "IMAGE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // pbImage
            // 
            this.pbImage.Name = "pbImage";
            this.pbImage.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // tbPassWord
            // 
            this.tbPassWord.AutoHeight = false;
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.PasswordChar = '*';
            // 
            // rbMemo
            // 
            this.rbMemo.AutoHeight = false;
            this.rbMemo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rbMemo.Name = "rbMemo";
            // 
            // cbRoles
            // 
            this.cbRoles.AutoHeight = false;
            this.cbRoles.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick;
            // 
            // FunctionImageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcImages);
            this.Controls.Add(this.plButtons);
            this.Name = "FunctionImageManager";
            this.Size = new System.Drawing.Size(687, 496);
            this.plButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPassWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ApplicationControlCommon.MyButton btSave;
        private ApplicationControlCommon.MyButton btAdd;
        private ApplicationControlCommon.MyButton btRefresh;
        private DevExpress.XtraGrid.GridControl gcImages;
        private DevExpress.XtraGrid.Views.Grid.GridView gvImages;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit tbPassWord;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit cbRoles;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit rbMemo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit pbImage;
    }
}
