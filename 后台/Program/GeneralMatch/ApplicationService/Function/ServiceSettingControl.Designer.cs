namespace ApplicationService
{
    partial class ServiceSettingControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceSettingControl));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btAdd = new ApplicationControlCommon.MyButton();
            this.btSave = new ApplicationControlCommon.MyButton();
            this.btSub = new ApplicationControlCommon.MyButton();
            this.gcService = new DevExpress.XtraGrid.GridControl();
            this.lvService = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.layoutViewColumn3 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewColumn4 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewColumn5 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.btDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutViewColumn6 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_layoutViewColumn3 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_layoutViewColumn4 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_layoutViewColumn2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_layoutViewColumn6 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_layoutViewColumn5 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 49);
            this.panel1.TabIndex = 1;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(465, 49);
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
            this.btAdd.Size = new System.Drawing.Size(149, 43);
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
            this.btSave.Location = new System.Drawing.Point(313, 3);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(149, 43);
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
            this.btSub.Location = new System.Drawing.Point(158, 3);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(149, 43);
            this.btSub.TabIndex = 11;
            this.btSub.Text = "  删除";
            this.btSub.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSub.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // gcService
            // 
            this.gcService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcService.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcService.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcService.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcService.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcService.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcService.Location = new System.Drawing.Point(0, 49);
            this.gcService.MainView = this.lvService;
            this.gcService.Name = "gcService";
            this.gcService.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.btDelete});
            this.gcService.Size = new System.Drawing.Size(465, 323);
            this.gcService.TabIndex = 2;
            this.gcService.UseEmbeddedNavigator = true;
            this.gcService.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lvService,
            this.gridView1});
            // 
            // lvService
            // 
            this.lvService.Appearance.CardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.lvService.Appearance.CardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.lvService.Appearance.CardCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lvService.Appearance.CardCaption.ForeColor = System.Drawing.Color.Black;
            this.lvService.Appearance.CardCaption.Options.UseBackColor = true;
            this.lvService.Appearance.CardCaption.Options.UseBorderColor = true;
            this.lvService.Appearance.CardCaption.Options.UseFont = true;
            this.lvService.Appearance.CardCaption.Options.UseForeColor = true;
            this.lvService.Appearance.FieldCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.lvService.Appearance.FieldCaption.BackColor2 = System.Drawing.Color.GhostWhite;
            this.lvService.Appearance.FieldCaption.ForeColor = System.Drawing.Color.Black;
            this.lvService.Appearance.FieldCaption.Options.UseBackColor = true;
            this.lvService.Appearance.FieldCaption.Options.UseForeColor = true;
            this.lvService.Appearance.FieldValue.BackColor = System.Drawing.Color.White;
            this.lvService.Appearance.FieldValue.ForeColor = System.Drawing.Color.Black;
            this.lvService.Appearance.FieldValue.Options.UseBackColor = true;
            this.lvService.Appearance.FieldValue.Options.UseForeColor = true;
            this.lvService.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.lvService.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.lvService.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.lvService.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.lvService.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.lvService.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.lvService.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.lvService.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.lvService.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lvService.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.lvService.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.lvService.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.lvService.Appearance.FilterPanel.Options.UseBackColor = true;
            this.lvService.Appearance.FilterPanel.Options.UseForeColor = true;
            this.lvService.Appearance.FocusedCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(128)))), ((int)(((byte)(151)))));
            this.lvService.Appearance.FocusedCardCaption.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(178)))), ((int)(((byte)(201)))));
            this.lvService.Appearance.FocusedCardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(128)))), ((int)(((byte)(151)))));
            this.lvService.Appearance.FocusedCardCaption.ForeColor = System.Drawing.Color.White;
            this.lvService.Appearance.FocusedCardCaption.Options.UseBackColor = true;
            this.lvService.Appearance.FocusedCardCaption.Options.UseBorderColor = true;
            this.lvService.Appearance.FocusedCardCaption.Options.UseForeColor = true;
            this.lvService.Appearance.HideSelectionCardCaption.BackColor = System.Drawing.Color.Gray;
            this.lvService.Appearance.HideSelectionCardCaption.BorderColor = System.Drawing.Color.Gray;
            this.lvService.Appearance.HideSelectionCardCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.lvService.Appearance.HideSelectionCardCaption.Options.UseBackColor = true;
            this.lvService.Appearance.HideSelectionCardCaption.Options.UseBorderColor = true;
            this.lvService.Appearance.HideSelectionCardCaption.Options.UseForeColor = true;
            this.lvService.Appearance.SelectedCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(138)))), ((int)(((byte)(161)))));
            this.lvService.Appearance.SelectedCardCaption.ForeColor = System.Drawing.Color.White;
            this.lvService.Appearance.SelectedCardCaption.Options.UseBackColor = true;
            this.lvService.Appearance.SelectedCardCaption.Options.UseForeColor = true;
            this.lvService.Appearance.SeparatorLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.lvService.Appearance.SeparatorLine.Options.UseBackColor = true;
            this.lvService.Appearance.ViewBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(205)))), ((int)(((byte)(220)))));
            this.lvService.Appearance.ViewBackground.Options.UseBackColor = true;
            this.lvService.CardCaptionFormat = "{3}";
            this.lvService.CardHorzInterval = 0;
            this.lvService.CardMinSize = new System.Drawing.Size(257, 200);
            this.lvService.CardVertInterval = 0;
            this.lvService.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumn1,
            this.layoutViewColumn2,
            this.layoutViewColumn3,
            this.layoutViewColumn4,
            this.layoutViewColumn5,
            this.layoutViewColumn6});
            this.lvService.GridControl = this.gcService;
            this.lvService.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_layoutViewColumn5});
            this.lvService.Name = "lvService";
            this.lvService.OptionsBehavior.AutoFocusNewCard = true;
            this.lvService.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.lvService.OptionsCustomization.AllowFilter = false;
            this.lvService.OptionsCustomization.AllowSort = false;
            this.lvService.OptionsItemText.TextToControlDistance = 7;
            this.lvService.OptionsView.CardsAlignment = DevExpress.XtraGrid.Views.Layout.CardsAlignment.Far;
            this.lvService.OptionsView.ShowCardExpandButton = false;
            this.lvService.OptionsView.ShowCardLines = false;
            this.lvService.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.lvService.OptionsView.ShowHeaderPanel = false;
            this.lvService.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel;
            this.lvService.PaintStyleName = "Office2003";
            this.lvService.TemplateCard = this.layoutViewCard1;
            this.lvService.ViewCaption = "{1}";
            this.lvService.ViewCaptionHeight = 30;
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.Caption = "服务名称";
            this.layoutViewColumn1.FieldName = "SERVICENAME";
            this.layoutViewColumn1.LayoutViewField = this.layoutViewField_layoutViewColumn1;
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            // 
            // layoutViewColumn2
            // 
            this.layoutViewColumn2.Caption = "备注";
            this.layoutViewColumn2.ColumnEdit = this.repositoryItemMemoEdit1;
            this.layoutViewColumn2.FieldName = "SERVICEDES";
            this.layoutViewColumn2.LayoutViewField = this.layoutViewField_layoutViewColumn2;
            this.layoutViewColumn2.Name = "layoutViewColumn2";
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // layoutViewColumn3
            // 
            this.layoutViewColumn3.Caption = "Dll";
            this.layoutViewColumn3.FieldName = "DLL";
            this.layoutViewColumn3.LayoutViewField = this.layoutViewField_layoutViewColumn3;
            this.layoutViewColumn3.Name = "layoutViewColumn3";
            // 
            // layoutViewColumn4
            // 
            this.layoutViewColumn4.Caption = "Modle";
            this.layoutViewColumn4.FieldName = "MODLE";
            this.layoutViewColumn4.LayoutViewField = this.layoutViewField_layoutViewColumn4;
            this.layoutViewColumn4.Name = "layoutViewColumn4";
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btDelete.Name = "btDelete";
            this.btDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // layoutViewColumn6
            // 
            this.layoutViewColumn6.Caption = "默认启动";
            this.layoutViewColumn6.FieldName = "BSTART";
            this.layoutViewColumn6.LayoutViewField = this.layoutViewField_layoutViewColumn6;
            this.layoutViewColumn6.Name = "layoutViewColumn6";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcService;
            this.gridView1.Name = "gridView1";
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_layoutViewColumn1,
            this.layoutViewField_layoutViewColumn3,
            this.layoutViewField_layoutViewColumn4,
            this.layoutViewField_layoutViewColumn2,
            this.layoutViewField_layoutViewColumn6});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 7;
            this.layoutViewCard1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // layoutViewField_layoutViewColumn1
            // 
            this.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 180;
            this.layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            this.layoutViewField_layoutViewColumn1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(247, 24);
            this.layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutViewField_layoutViewColumn3
            // 
            this.layoutViewField_layoutViewColumn3.EditorPreferredWidth = 180;
            this.layoutViewField_layoutViewColumn3.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_layoutViewColumn3.Name = "layoutViewField_layoutViewColumn3";
            this.layoutViewField_layoutViewColumn3.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutViewField_layoutViewColumn3.Size = new System.Drawing.Size(247, 24);
            this.layoutViewField_layoutViewColumn3.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutViewField_layoutViewColumn4
            // 
            this.layoutViewField_layoutViewColumn4.EditorPreferredWidth = 180;
            this.layoutViewField_layoutViewColumn4.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_layoutViewColumn4.Name = "layoutViewField_layoutViewColumn4";
            this.layoutViewField_layoutViewColumn4.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutViewField_layoutViewColumn4.Size = new System.Drawing.Size(247, 24);
            this.layoutViewField_layoutViewColumn4.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutViewField_layoutViewColumn2
            // 
            this.layoutViewField_layoutViewColumn2.EditorPreferredWidth = 239;
            this.layoutViewField_layoutViewColumn2.Location = new System.Drawing.Point(0, 96);
            this.layoutViewField_layoutViewColumn2.Name = "layoutViewField_layoutViewColumn2";
            this.layoutViewField_layoutViewColumn2.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutViewField_layoutViewColumn2.Size = new System.Drawing.Size(247, 75);
            this.layoutViewField_layoutViewColumn2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_layoutViewColumn2.TextToControlDistance = 0;
            this.layoutViewField_layoutViewColumn2.TextVisible = false;
            // 
            // layoutViewField_layoutViewColumn6
            // 
            this.layoutViewField_layoutViewColumn6.EditorPreferredWidth = 180;
            this.layoutViewField_layoutViewColumn6.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_layoutViewColumn6.Name = "layoutViewField_layoutViewColumn6";
            this.layoutViewField_layoutViewColumn6.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutViewField_layoutViewColumn6.Size = new System.Drawing.Size(247, 24);
            this.layoutViewField_layoutViewColumn6.TextSize = new System.Drawing.Size(52, 14);
            // 
            // layoutViewField_layoutViewColumn5
            // 
            this.layoutViewField_layoutViewColumn5.EditorPreferredWidth = 20;
            this.layoutViewField_layoutViewColumn5.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_layoutViewColumn5.MaxSize = new System.Drawing.Size(80, 34);
            this.layoutViewField_layoutViewColumn5.MinSize = new System.Drawing.Size(80, 34);
            this.layoutViewField_layoutViewColumn5.Name = "layoutViewField_layoutViewColumn5";
            this.layoutViewField_layoutViewColumn5.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutViewField_layoutViewColumn5.Size = new System.Drawing.Size(247, 171);
            this.layoutViewField_layoutViewColumn5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutViewField_layoutViewColumn5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_layoutViewColumn5.TextToControlDistance = 0;
            this.layoutViewField_layoutViewColumn5.TextVisible = false;
            // 
            // ServiceSettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcService);
            this.Controls.Add(this.panel1);
            this.Name = "ServiceSettingControl";
            this.Size = new System.Drawing.Size(465, 372);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ApplicationControlCommon.MyButton btSave;
        private ApplicationControlCommon.MyButton btAdd;
        private ApplicationControlCommon.MyButton btSub;
        private DevExpress.XtraGrid.GridControl gcService;
        private DevExpress.XtraGrid.Views.Layout.LayoutView lvService;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn3;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn4;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btDelete;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn6;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn3;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn4;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn5;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn6;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}
