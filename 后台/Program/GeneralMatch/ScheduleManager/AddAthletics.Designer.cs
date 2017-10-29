namespace ScheduleManager
{
    partial class AddAthletics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gcAthletics = new DevExpress.XtraGrid.GridControl();
            this.gvAthletes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbChoose = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btChooseAll = new ApplicationControlCommon.MyButton();
            this.btInChoose = new ApplicationControlCommon.MyButton();
            this.btUnChoose = new ApplicationControlCommon.MyButton();
            this.rbSex = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gcAthletics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAthletes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChoose)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbSex.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcAthletics
            // 
            this.gcAthletics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAthletics.Location = new System.Drawing.Point(0, 36);
            this.gcAthletics.MainView = this.gvAthletes;
            this.gcAthletics.Name = "gcAthletics";
            this.gcAthletics.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbChoose});
            this.gcAthletics.Size = new System.Drawing.Size(472, 298);
            this.gcAthletics.TabIndex = 3;
            this.gcAthletics.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAthletes});
            // 
            // gvAthletes
            // 
            this.gvAthletes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvAthletes.GridControl = this.gcAthletics;
            this.gvAthletes.Name = "gvAthletes";
            this.gvAthletes.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "姓      名";
            this.gridColumn1.FieldName = "NAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 125;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "号      码";
            this.gridColumn2.FieldName = "BIBNUM";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 125;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "性      别";
            this.gridColumn3.FieldName = "SEX";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 133;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "选      择";
            this.gridColumn4.ColumnEdit = this.cbChoose;
            this.gridColumn4.FieldName = "CHOOSE";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 68;
            // 
            // cbChoose
            // 
            this.cbChoose.AutoHeight = false;
            this.cbChoose.Name = "cbChoose";
            this.cbChoose.ValueChecked = 1;
            this.cbChoose.ValueUnchecked = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btChooseAll, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btInChoose, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btUnChoose, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.rbSex, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(472, 36);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // btChooseAll
            // 
            this.btChooseAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btChooseAll.EnglishText = null;
            this.btChooseAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btChooseAll.FOCUSFONT = null;
            this.btChooseAll.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btChooseAll.Location = new System.Drawing.Point(3, 3);
            this.btChooseAll.Name = "btChooseAll";
            this.btChooseAll.Size = new System.Drawing.Size(94, 30);
            this.btChooseAll.TabIndex = 22;
            this.btChooseAll.Text = "全选";
            this.btChooseAll.UNFOCUSFONT = null;
            this.btChooseAll.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btChooseAll.UseVisualStyleBackColor = true;
            this.btChooseAll.Click += new System.EventHandler(this.btChooseAll_Click);
            // 
            // btInChoose
            // 
            this.btInChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btInChoose.EnglishText = null;
            this.btInChoose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btInChoose.FOCUSFONT = null;
            this.btInChoose.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btInChoose.Location = new System.Drawing.Point(103, 3);
            this.btInChoose.Name = "btInChoose";
            this.btInChoose.Size = new System.Drawing.Size(94, 30);
            this.btInChoose.TabIndex = 23;
            this.btInChoose.Text = "反选";
            this.btInChoose.UNFOCUSFONT = null;
            this.btInChoose.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btInChoose.UseVisualStyleBackColor = true;
            this.btInChoose.Click += new System.EventHandler(this.btInChoose_Click);
            // 
            // btUnChoose
            // 
            this.btUnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btUnChoose.EnglishText = null;
            this.btUnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btUnChoose.FOCUSFONT = null;
            this.btUnChoose.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btUnChoose.Location = new System.Drawing.Point(203, 3);
            this.btUnChoose.Name = "btUnChoose";
            this.btUnChoose.Size = new System.Drawing.Size(94, 30);
            this.btUnChoose.TabIndex = 24;
            this.btUnChoose.Text = "不选";
            this.btUnChoose.UNFOCUSFONT = null;
            this.btUnChoose.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btUnChoose.UseVisualStyleBackColor = true;
            this.btUnChoose.Click += new System.EventHandler(this.btUnChoose_Click);
            // 
            // rbSex
            // 
            this.rbSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbSex.EditValue = -1;
            this.rbSex.Location = new System.Drawing.Point(303, 3);
            this.rbSex.Name = "rbSex";
            this.rbSex.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(-1, "全部"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "男"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "女")});
            this.rbSex.Size = new System.Drawing.Size(166, 30);
            this.rbSex.TabIndex = 25;
            this.rbSex.SelectedIndexChanged += new System.EventHandler(this.rbSex_SelectedIndexChanged);
            // 
            // AddAthletics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 381);
            this.Controls.Add(this.gcAthletics);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "AddAthletics";
            this.Text = "AddAthletics";
            this.OkClick += new ApplicationControlCommon.DialogForm.OkClickCallback(this.AddAthletics_OkClick);
            this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
            this.Controls.SetChildIndex(this.gcAthletics, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcAthletics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAthletes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChoose)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rbSex.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcAthletics;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAthletes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ApplicationControlCommon.MyButton btChooseAll;
        private ApplicationControlCommon.MyButton btInChoose;
        private ApplicationControlCommon.MyButton btUnChoose;
        private DevExpress.XtraEditors.RadioGroup rbSex;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit cbChoose;
    }
}