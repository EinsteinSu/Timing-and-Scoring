namespace SystemManager
{
    partial class FunctionManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctionManager));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.plButtons = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btAdd = new ApplicationControlCommon.MyButton();
            this.btAddChild = new ApplicationControlCommon.MyButton();
            this.btRefresh = new ApplicationControlCommon.MyButton();
            this.btSave = new ApplicationControlCommon.MyButton();
            this.treeFunction = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.rbType = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.cbImages = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.treeListColumn8 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn9 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn10 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.plButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // plButtons
            // 
            this.plButtons.Controls.Add(this.tableLayoutPanel1);
            this.plButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.plButtons.Location = new System.Drawing.Point(0, 0);
            this.plButtons.Name = "plButtons";
            this.plButtons.Size = new System.Drawing.Size(739, 71);
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
            this.tableLayoutPanel1.Controls.Add(this.btAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btAddChild, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btRefresh, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btSave, 3, 0);
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
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn6,
            this.treeListColumn7,
            this.treeListColumn8,
            this.treeListColumn9,
            this.treeListColumn10});
            this.treeFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeFunction.KeyFieldName = "GUID";
            this.treeFunction.Location = new System.Drawing.Point(0, 71);
            this.treeFunction.Name = "treeFunction";
            this.treeFunction.OptionsBehavior.PopulateServiceColumns = true;
            this.treeFunction.OptionsView.AutoWidth = false;
            this.treeFunction.OptionsView.EnableAppearanceEvenRow = true;
            this.treeFunction.OptionsView.EnableAppearanceOddRow = true;
            this.treeFunction.ParentFieldName = "PGUID";
            this.treeFunction.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rbType,
            this.cbImages,
            this.btDelete});
            this.treeFunction.RowHeight = 32;
            this.treeFunction.Size = new System.Drawing.Size(739, 440);
            this.treeFunction.TabIndex = 3;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "名称";
            this.treeListColumn1.FieldName = "NAME";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 169;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "名称（英文）";
            this.treeListColumn2.FieldName = "NAME_EN";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 96;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "类型";
            this.treeListColumn3.ColumnEdit = this.rbType;
            this.treeListColumn3.FieldName = "TYPE";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            this.treeListColumn3.Width = 165;
            // 
            // rbType
            // 
            this.rbType.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Null", "无"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("UserControl", "用户控件"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Method", "方法")});
            this.rbType.Name = "rbType";
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "动态链接库";
            this.treeListColumn4.FieldName = "DLL";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 3;
            this.treeListColumn4.Width = 113;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "模块";
            this.treeListColumn5.FieldName = "MODLE";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 4;
            this.treeListColumn5.Width = 116;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "方法";
            this.treeListColumn6.FieldName = "METHOD";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 5;
            this.treeListColumn6.Width = 107;
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "图片";
            this.treeListColumn7.ColumnEdit = this.cbImages;
            this.treeListColumn7.FieldName = "IMAGEINDEX";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 6;
            this.treeListColumn7.Width = 93;
            // 
            // cbImages
            // 
            this.cbImages.AutoHeight = false;
            this.cbImages.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbImages.Name = "cbImages";
            // 
            // treeListColumn8
            // 
            this.treeListColumn8.Caption = "备注";
            this.treeListColumn8.FieldName = "MEMO";
            this.treeListColumn8.Name = "treeListColumn8";
            this.treeListColumn8.Visible = true;
            this.treeListColumn8.VisibleIndex = 8;
            this.treeListColumn8.Width = 122;
            // 
            // treeListColumn9
            // 
            this.treeListColumn9.Caption = "排序编号";
            this.treeListColumn9.FieldName = "ORDERID";
            this.treeListColumn9.Name = "treeListColumn9";
            this.treeListColumn9.Visible = true;
            this.treeListColumn9.VisibleIndex = 7;
            // 
            // treeListColumn10
            // 
            this.treeListColumn10.ColumnEdit = this.btDelete;
            this.treeListColumn10.Name = "treeListColumn10";
            this.treeListColumn10.Visible = true;
            this.treeListColumn10.VisibleIndex = 9;
            this.treeListColumn10.Width = 104;
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
            // FunctionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeFunction);
            this.Controls.Add(this.plButtons);
            this.Name = "FunctionManager";
            this.Size = new System.Drawing.Size(739, 511);
            this.plButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ApplicationControlCommon.MyButton btSave;
        private ApplicationControlCommon.MyButton btAddChild;
        private ApplicationControlCommon.MyButton btRefresh;
        private DevExpress.XtraTreeList.TreeList treeFunction;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup rbType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cbImages;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn8;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn9;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn10;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btDelete;
        private ApplicationControlCommon.MyButton btAdd;
    }
}
