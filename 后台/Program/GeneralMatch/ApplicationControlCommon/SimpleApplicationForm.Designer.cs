namespace ApplicationControlCommon
{
    partial class SimpleApplicationForm
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
            this.gbTitle = new System.Windows.Forms.GroupBox();
            this.pbTitle = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbFunctions = new System.Windows.Forms.GroupBox();
            this.tlpFunctions = new System.Windows.Forms.TableLayoutPanel();
            this.lbFunctionTitle = new System.Windows.Forms.Label();
            this.plParent = new ApplicationControlCommon.ParentControl();
            this.gbTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
            this.gbFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTitle
            // 
            this.gbTitle.Controls.Add(this.lbTitle);
            this.gbTitle.Controls.Add(this.pbTitle);
            this.gbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTitle.Location = new System.Drawing.Point(0, 0);
            this.gbTitle.Name = "gbTitle";
            this.gbTitle.Size = new System.Drawing.Size(771, 81);
            this.gbTitle.TabIndex = 0;
            this.gbTitle.TabStop = false;
            // 
            // pbTitle
            // 
            this.pbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbTitle.Location = new System.Drawing.Point(3, 17);
            this.pbTitle.Name = "pbTitle";
            this.pbTitle.Size = new System.Drawing.Size(100, 61);
            this.pbTitle.TabIndex = 0;
            this.pbTitle.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.Location = new System.Drawing.Point(103, 17);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(665, 61);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "title";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbFunctions
            // 
            this.gbFunctions.Controls.Add(this.tlpFunctions);
            this.gbFunctions.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbFunctions.Location = new System.Drawing.Point(0, 81);
            this.gbFunctions.Name = "gbFunctions";
            this.gbFunctions.Size = new System.Drawing.Size(145, 398);
            this.gbFunctions.TabIndex = 1;
            this.gbFunctions.TabStop = false;
            // 
            // tlpFunctions
            // 
            this.tlpFunctions.ColumnCount = 1;
            this.tlpFunctions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFunctions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFunctions.Location = new System.Drawing.Point(3, 17);
            this.tlpFunctions.Name = "tlpFunctions";
            this.tlpFunctions.RowCount = 1;
            this.tlpFunctions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFunctions.Size = new System.Drawing.Size(139, 378);
            this.tlpFunctions.TabIndex = 0;
            // 
            // lbFunctionTitle
            // 
            this.lbFunctionTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFunctionTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFunctionTitle.Location = new System.Drawing.Point(145, 81);
            this.lbFunctionTitle.Name = "lbFunctionTitle";
            this.lbFunctionTitle.Size = new System.Drawing.Size(626, 23);
            this.lbFunctionTitle.TabIndex = 2;
            this.lbFunctionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plParent
            // 
            this.plParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plParent.Location = new System.Drawing.Point(145, 104);
            this.plParent.Name = "plParent";
            this.plParent.Size = new System.Drawing.Size(626, 375);
            this.plParent.TabIndex = 3;
            this.plParent.ShowControled += new ApplicationControlCommon.ParentControl.ShowControledCallback(this.plParent_ShowControled);
            // 
            // SimpleApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 479);
            this.Controls.Add(this.plParent);
            this.Controls.Add(this.lbFunctionTitle);
            this.Controls.Add(this.gbFunctions);
            this.Controls.Add(this.gbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "SimpleApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SimpleApplicationForm";
            this.gbTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
            this.gbFunctions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pbTitle;
        private System.Windows.Forms.GroupBox gbFunctions;
        private System.Windows.Forms.TableLayoutPanel tlpFunctions;
        private System.Windows.Forms.Label lbFunctionTitle;
        private ParentControl plParent;
    }
}