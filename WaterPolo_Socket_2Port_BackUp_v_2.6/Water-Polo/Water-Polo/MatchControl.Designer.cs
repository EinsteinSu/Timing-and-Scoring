namespace Water_Polo
{
    partial class MatchControl
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
            this.lbNumber = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tlpFouls = new System.Windows.Forms.TableLayoutPanel();
            this.lbFoul3 = new System.Windows.Forms.Label();
            this.lbFoul2 = new System.Windows.Forms.Label();
            this.lbFoul1 = new System.Windows.Forms.Label();
            this.lbSerious = new System.Windows.Forms.Label();
            this.tlpFouls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNumber
            // 
            this.lbNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbNumber.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.Location = new System.Drawing.Point(0, 0);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(33, 24);
            this.lbNumber.TabIndex = 0;
            this.lbNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(33, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(149, 24);
            this.lbName.TabIndex = 1;
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpFouls
            // 
            this.tlpFouls.ColumnCount = 3;
            this.tlpFouls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFouls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFouls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFouls.Controls.Add(this.lbFoul3, 0, 0);
            this.tlpFouls.Controls.Add(this.lbFoul2, 0, 0);
            this.tlpFouls.Controls.Add(this.lbFoul1, 0, 0);
            this.tlpFouls.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpFouls.Location = new System.Drawing.Point(182, 0);
            this.tlpFouls.Name = "tlpFouls";
            this.tlpFouls.RowCount = 1;
            this.tlpFouls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFouls.Size = new System.Drawing.Size(67, 24);
            this.tlpFouls.TabIndex = 2;
            // 
            // lbFoul3
            // 
            this.lbFoul3.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbFoul3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoul3.ForeColor = System.Drawing.Color.Black;
            this.lbFoul3.Location = new System.Drawing.Point(47, 0);
            this.lbFoul3.Name = "lbFoul3";
            this.lbFoul3.Size = new System.Drawing.Size(17, 24);
            this.lbFoul3.TabIndex = 4;
            this.lbFoul3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFoul2
            // 
            this.lbFoul2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbFoul2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoul2.ForeColor = System.Drawing.Color.Black;
            this.lbFoul2.Location = new System.Drawing.Point(25, 0);
            this.lbFoul2.Name = "lbFoul2";
            this.lbFoul2.Size = new System.Drawing.Size(16, 24);
            this.lbFoul2.TabIndex = 3;
            this.lbFoul2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFoul1
            // 
            this.lbFoul1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbFoul1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoul1.ForeColor = System.Drawing.Color.Black;
            this.lbFoul1.Location = new System.Drawing.Point(3, 0);
            this.lbFoul1.Name = "lbFoul1";
            this.lbFoul1.Size = new System.Drawing.Size(16, 24);
            this.lbFoul1.TabIndex = 2;
            this.lbFoul1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSerious
            // 
            this.lbSerious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSerious.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSerious.ForeColor = System.Drawing.Color.Red;
            this.lbSerious.Location = new System.Drawing.Point(249, 0);
            this.lbSerious.Name = "lbSerious";
            this.lbSerious.Size = new System.Drawing.Size(29, 24);
            this.lbSerious.TabIndex = 3;
            this.lbSerious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MatchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbSerious);
            this.Controls.Add(this.tlpFouls);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbNumber);
            this.Name = "MatchControl";
            this.Size = new System.Drawing.Size(278, 24);
            this.tlpFouls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TableLayoutPanel tlpFouls;
        private System.Windows.Forms.Label lbFoul3;
        private System.Windows.Forms.Label lbFoul2;
        private System.Windows.Forms.Label lbFoul1;
        private System.Windows.Forms.Label lbSerious;
    }
}
