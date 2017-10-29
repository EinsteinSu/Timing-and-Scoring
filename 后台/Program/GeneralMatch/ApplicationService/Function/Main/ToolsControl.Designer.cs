namespace ApplicationService
{
    partial class ToolsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolsControl));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gcRelease = new DevExpress.XtraGrid.GridControl();
            this.lvRelease = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.layoutViewField_layoutViewColumn2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn3 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn3 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn5 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.btDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutViewField_layoutViewColumn5 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btAdd = new ApplicationControlCommon.MyButton();
            this.btSave = new ApplicationControlCommon.MyButton();
            this.btSub = new ApplicationControlCommon.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRelease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvRelease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(630, 507);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcRelease);
            this.xtraTabPage1.Controls.Add(this.panel1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(623, 477);
            this.xtraTabPage1.Text = "版本管理";
            // 
            // gcRelease
            // 
            this.gcRelease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRelease.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcRelease.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcRelease.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcRelease.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcRelease.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcRelease.Location = new System.Drawing.Point(0, 49);
            this.gcRelease.MainView = this.lvRelease;
            this.gcRelease.Name = "gcRelease";
            this.gcRelease.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.btDelete});
            this.gcRelease.Size = new System.Drawing.Size(623, 428);
            this.gcRelease.TabIndex = 4;
            this.gcRelease.UseEmbeddedNavigator = true;
            this.gcRelease.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lvRelease,
            this.gridView1});
            // 
            // lvRelease
            // 
            this.lvRelease.Appearance.CardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.lvRelease.Appearance.CardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.lvRelease.Appearance.CardCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lvRelease.Appearance.CardCaption.ForeColor = System.Drawing.Color.Black;
            this.lvRelease.Appearance.CardCaption.Options.UseBackColor = true;
            this.lvRelease.Appearance.CardCaption.Options.UseBorderColor = true;
            this.lvRelease.Appearance.CardCaption.Options.UseFont = true;
            this.lvRelease.Appearance.CardCaption.Options.UseForeColor = true;
            this.lvRelease.Appearance.FieldCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.lvRelease.Appearance.FieldCaption.BackColor2 = System.Drawing.Color.GhostWhite;
            this.lvRelease.Appearance.FieldCaption.ForeColor = System.Drawing.Color.Black;
            this.lvRelease.Appearance.FieldCaption.Options.UseBackColor = true;
            this.lvRelease.Appearance.FieldCaption.Options.UseForeColor = true;
            this.lvRelease.Appearance.FieldValue.BackColor = System.Drawing.Color.White;
            this.lvRelease.Appearance.FieldValue.ForeColor = System.Drawing.Color.Black;
            this.lvRelease.Appearance.FieldValue.Options.UseBackColor = true;
            this.lvRelease.Appearance.FieldValue.Options.UseForeColor = true;
            this.lvRelease.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.lvRelease.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.lvRelease.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.lvRelease.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.lvRelease.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.lvRelease.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.lvRelease.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.lvRelease.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.lvRelease.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lvRelease.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.lvRelease.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.lvRelease.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.lvRelease.Appearance.FilterPanel.Options.UseBackColor = true;
            this.lvRelease.Appearance.FilterPanel.Options.UseForeColor = true;
            this.lvRelease.Appearance.FocusedCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(128)))), ((int)(((byte)(151)))));
            this.lvRelease.Appearance.FocusedCardCaption.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(178)))), ((int)(((byte)(201)))));
            this.lvRelease.Appearance.FocusedCardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(128)))), ((int)(((byte)(151)))));
            this.lvRelease.Appearance.FocusedCardCaption.ForeColor = System.Drawing.Color.White;
            this.lvRelease.Appearance.FocusedCardCaption.Options.UseBackColor = true;
            this.lvRelease.Appearance.FocusedCardCaption.Options.UseBorderColor = true;
            this.lvRelease.Appearance.FocusedCardCaption.Options.UseForeColor = true;
            this.lvRelease.Appearance.HideSelectionCardCaption.BackColor = System.Drawing.Color.Gray;
            this.lvRelease.Appearance.HideSelectionCardCaption.BorderColor = System.Drawing.Color.Gray;
            this.lvRelease.Appearance.HideSelectionCardCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.lvRelease.Appearance.HideSelectionCardCaption.Options.UseBackColor = true;
            this.lvRelease.Appearance.HideSelectionCardCaption.Options.UseBorderColor = true;
            this.lvRelease.Appearance.HideSelectionCardCaption.Options.UseForeColor = true;
            this.lvRelease.Appearance.SelectedCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(138)))), ((int)(((byte)(161)))));
            this.lvRelease.Appearance.SelectedCardCaption.ForeColor = System.Drawing.Color.White;
            this.lvRelease.Appearance.SelectedCardCaption.Options.UseBackColor = true;
            this.lvRelease.Appearance.SelectedCardCaption.Options.UseForeColor = true;
            this.lvRelease.Appearance.SeparatorLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.lvRelease.Appearance.SeparatorLine.Options.UseBackColor = true;
            this.lvRelease.Appearance.ViewBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(205)))), ((int)(((byte)(220)))));
            this.lvRelease.Appearance.ViewBackground.Options.UseBackColor = true;
            this.lvRelease.CardCaptionFormat = "版本号：{2}";
            this.lvRelease.CardMinSize = new System.Drawing.Size(253, 188);
            this.lvRelease.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumn1,
            this.layoutViewColumn2,
            this.layoutViewColumn3,
            this.layoutViewColumn5});
            this.lvRelease.GridControl = this.gcRelease;
            this.lvRelease.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_layoutViewColumn5});
            this.lvRelease.Name = "lvRelease";
            this.lvRelease.OptionsBehavior.AutoFocusNewCard = true;
            this.lvRelease.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.lvRelease.OptionsCustomization.AllowFilter = false;
            this.lvRelease.OptionsCustomization.AllowSort = false;
            this.lvRelease.OptionsView.ShowCardExpandButton = false;
            this.lvRelease.OptionsView.ShowCardLines = false;
            this.lvRelease.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.lvRelease.OptionsView.ShowHeaderPanel = false;
            this.lvRelease.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel;
            this.lvRelease.PaintStyleName = "Office2003";
            this.lvRelease.TemplateCard = this.layoutViewCard1;
            this.lvRelease.ViewCaption = "{1}";
            this.lvRelease.ViewCaptionHeight = 30;
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.Caption = "版本号";
            this.layoutViewColumn1.FieldName = "RELEASE";
            this.layoutViewColumn1.LayoutViewField = this.layoutViewField_layoutViewColumn1;
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            // 
            // layoutViewField_layoutViewColumn1
            // 
            this.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 184;
            this.layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            this.layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(239, 26);
            this.layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(40, 14);
            this.layoutViewField_layoutViewColumn1.TextToControlDistance = 5;
            // 
            // layoutViewColumn2
            // 
            this.layoutViewColumn2.Caption = "备注";
            this.layoutViewColumn2.ColumnEdit = this.repositoryItemMemoEdit1;
            this.layoutViewColumn2.FieldName = "REMARKS";
            this.layoutViewColumn2.LayoutViewField = this.layoutViewField_layoutViewColumn2;
            this.layoutViewColumn2.Name = "layoutViewColumn2";
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // layoutViewField_layoutViewColumn2
            // 
            this.layoutViewField_layoutViewColumn2.EditorPreferredWidth = 229;
            this.layoutViewField_layoutViewColumn2.Location = new System.Drawing.Point(0, 52);
            this.layoutViewField_layoutViewColumn2.Name = "layoutViewField_layoutViewColumn2";
            this.layoutViewField_layoutViewColumn2.Size = new System.Drawing.Size(239, 98);
            this.layoutViewField_layoutViewColumn2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_layoutViewColumn2.TextToControlDistance = 0;
            this.layoutViewField_layoutViewColumn2.TextVisible = false;
            // 
            // layoutViewColumn3
            // 
            this.layoutViewColumn3.Caption = "文件名";
            this.layoutViewColumn3.FieldName = "FILENAME";
            this.layoutViewColumn3.LayoutViewField = this.layoutViewField_layoutViewColumn3;
            this.layoutViewColumn3.Name = "layoutViewColumn3";
            // 
            // layoutViewField_layoutViewColumn3
            // 
            this.layoutViewField_layoutViewColumn3.EditorPreferredWidth = 184;
            this.layoutViewField_layoutViewColumn3.Location = new System.Drawing.Point(0, 26);
            this.layoutViewField_layoutViewColumn3.Name = "layoutViewField_layoutViewColumn3";
            this.layoutViewField_layoutViewColumn3.Size = new System.Drawing.Size(239, 26);
            this.layoutViewField_layoutViewColumn3.TextSize = new System.Drawing.Size(40, 14);
            this.layoutViewField_layoutViewColumn3.TextToControlDistance = 5;
            // 
            // layoutViewColumn5
            // 
            this.layoutViewColumn5.Caption = "layoutViewColumn5";
            this.layoutViewColumn5.ColumnEdit = this.btDelete;
            this.layoutViewColumn5.LayoutViewField = this.layoutViewField_layoutViewColumn5;
            this.layoutViewColumn5.Name = "layoutViewColumn5";
            // 
            // btDelete
            // 
            this.btDelete.AutoHeight = false;
            this.btDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btDelete.Name = "btDelete";
            this.btDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // layoutViewField_layoutViewColumn5
            // 
            this.layoutViewField_layoutViewColumn5.EditorPreferredWidth = 20;
            this.layoutViewField_layoutViewColumn5.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_layoutViewColumn5.MaxSize = new System.Drawing.Size(80, 34);
            this.layoutViewField_layoutViewColumn5.MinSize = new System.Drawing.Size(80, 34);
            this.layoutViewField_layoutViewColumn5.Name = "layoutViewField_layoutViewColumn5";
            this.layoutViewField_layoutViewColumn5.Size = new System.Drawing.Size(249, 115);
            this.layoutViewField_layoutViewColumn5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutViewField_layoutViewColumn5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_layoutViewColumn5.TextToControlDistance = 0;
            this.layoutViewField_layoutViewColumn5.TextVisible = false;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_layoutViewColumn1,
            this.layoutViewField_layoutViewColumn3,
            this.layoutViewField_layoutViewColumn2});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcRelease;
            this.gridView1.Name = "gridView1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 49);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btSave, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btSub, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(623, 49);
            this.tableLayoutPanel1.TabIndex = 13;
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
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdd.Location = new System.Drawing.Point(3, 3);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(201, 43);
            this.btAdd.TabIndex = 12;
            this.btAdd.Text = "  新增";
            this.btAdd.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
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
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(417, 3);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(203, 43);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "  保存";
            this.btSave.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSave.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btSub
            // 
            this.btSub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btSub.EnglishText = null;
            this.btSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSub.FOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSub.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btSub.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSub.Image = ((System.Drawing.Image)(resources.GetObject("btSub.Image")));
            this.btSub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSub.Location = new System.Drawing.Point(210, 3);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(201, 43);
            this.btSub.TabIndex = 11;
            this.btSub.Text = "  删除";
            this.btSub.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSub.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // ToolsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "ToolsControl";
            this.Size = new System.Drawing.Size(630, 507);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRelease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvRelease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ApplicationControlCommon.MyButton btAdd;
        private ApplicationControlCommon.MyButton btSave;
        private ApplicationControlCommon.MyButton btSub;
        private DevExpress.XtraGrid.GridControl gcRelease;
        private DevExpress.XtraGrid.Views.Layout.LayoutView lvRelease;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn3;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn3;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btDelete;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn5;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
