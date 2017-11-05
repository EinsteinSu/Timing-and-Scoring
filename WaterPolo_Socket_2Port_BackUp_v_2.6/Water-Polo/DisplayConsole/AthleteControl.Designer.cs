namespace DisplayConsole
{
    partial class AthleteControl
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
            this.lbSerious = new System.Windows.Forms.Label();
            this.lbTTime = new System.Windows.Forms.Label();
            this.lbFoul1 = new System.Windows.Forms.Label();
            this.lbFoul2 = new System.Windows.Forms.Label();
            this.tlpFouls = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFouls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNumber
            // 
            this.lbNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbNumber.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.ForeColor = System.Drawing.Color.Gold;
            this.lbNumber.Location = new System.Drawing.Point(0, 0);
            this.lbNumber.Margin = new System.Windows.Forms.Padding(0);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(87, 49);
            this.lbNumber.TabIndex = 4;
            this.lbNumber.Text = "12";
            this.lbNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("Broadway", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Gold;
            this.lbName.Location = new System.Drawing.Point(87, 0);
            this.lbName.Margin = new System.Windows.Forms.Padding(0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(385, 49);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "SSSSSSSSSSSS";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSerious
            // 
            this.lbSerious.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbSerious.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSerious.ForeColor = System.Drawing.Color.Red;
            this.lbSerious.Location = new System.Drawing.Point(552, 0);
            this.lbSerious.Margin = new System.Windows.Forms.Padding(0);
            this.lbSerious.Name = "lbSerious";
            this.lbSerious.Size = new System.Drawing.Size(32, 49);
            this.lbSerious.TabIndex = 7;
            this.lbSerious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTTime
            // 
            this.lbTTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTTime.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTTime.ForeColor = System.Drawing.Color.Red;
            this.lbTTime.Location = new System.Drawing.Point(584, 0);
            this.lbTTime.Margin = new System.Windows.Forms.Padding(0);
            this.lbTTime.Name = "lbTTime";
            this.lbTTime.Size = new System.Drawing.Size(80, 49);
            this.lbTTime.TabIndex = 8;
            this.lbTTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFoul1
            // 
            this.lbFoul1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFoul1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoul1.ForeColor = System.Drawing.Color.Gold;
            this.lbFoul1.Location = new System.Drawing.Point(0, 0);
            this.lbFoul1.Margin = new System.Windows.Forms.Padding(0);
            this.lbFoul1.Name = "lbFoul1";
            this.lbFoul1.Size = new System.Drawing.Size(40, 49);
            this.lbFoul1.TabIndex = 2;
            this.lbFoul1.Tag = "";
            this.lbFoul1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFoul2
            // 
            this.lbFoul2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFoul2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoul2.ForeColor = System.Drawing.Color.Gold;
            this.lbFoul2.Location = new System.Drawing.Point(40, 0);
            this.lbFoul2.Margin = new System.Windows.Forms.Padding(0);
            this.lbFoul2.Name = "lbFoul2";
            this.lbFoul2.Size = new System.Drawing.Size(40, 49);
            this.lbFoul2.TabIndex = 3;
            this.lbFoul2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpFouls
            // 
            this.tlpFouls.ColumnCount = 2;
            this.tlpFouls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFouls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFouls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpFouls.Controls.Add(this.lbFoul2, 0, 0);
            this.tlpFouls.Controls.Add(this.lbFoul1, 0, 0);
            this.tlpFouls.Dock = System.Windows.Forms.DockStyle.Right;
            this.tlpFouls.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tlpFouls.Location = new System.Drawing.Point(472, 0);
            this.tlpFouls.Margin = new System.Windows.Forms.Padding(4);
            this.tlpFouls.Name = "tlpFouls";
            this.tlpFouls.RowCount = 1;
            this.tlpFouls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFouls.Size = new System.Drawing.Size(80, 49);
            this.tlpFouls.TabIndex = 6;
            // 
            // AthleteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tlpFouls);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.lbSerious);
            this.Controls.Add(this.lbTTime);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AthleteControl";
            this.Size = new System.Drawing.Size(664, 49);
            this.tlpFouls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSerious;
        private System.Windows.Forms.Label lbTTime;
        private System.Windows.Forms.Label lbFoul1;
        private System.Windows.Forms.Label lbFoul2;
        private System.Windows.Forms.TableLayoutPanel tlpFouls;
    }
}
