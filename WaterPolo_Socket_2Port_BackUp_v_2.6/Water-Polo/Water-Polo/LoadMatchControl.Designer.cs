namespace Water_Polo
{
    partial class LoadMatchControl
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
            _socket.StopListening();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbScheduleName = new System.Windows.Forms.Label();
            this.btLoadSchedule = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tlpTeamA = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTeamB = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbScoreA = new System.Windows.Forms.Label();
            this.lbTeamA = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbScoreB = new System.Windows.Forms.Label();
            this.lbTeamB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbScheduleName);
            this.panel1.Controls.Add(this.btLoadSchedule);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 44);
            this.panel1.TabIndex = 0;
            // 
            // lbScheduleName
            // 
            this.lbScheduleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbScheduleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbScheduleName.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScheduleName.Location = new System.Drawing.Point(127, 0);
            this.lbScheduleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbScheduleName.Name = "lbScheduleName";
            this.lbScheduleName.Size = new System.Drawing.Size(862, 44);
            this.lbScheduleName.TabIndex = 1;
            this.lbScheduleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLoadSchedule
            // 
            this.btLoadSchedule.Dock = System.Windows.Forms.DockStyle.Left;
            this.btLoadSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLoadSchedule.Location = new System.Drawing.Point(0, 0);
            this.btLoadSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLoadSchedule.Name = "btLoadSchedule";
            this.btLoadSchedule.Size = new System.Drawing.Size(127, 44);
            this.btLoadSchedule.TabIndex = 0;
            this.btLoadSchedule.Text = "加载比赛";
            this.btLoadSchedule.UseVisualStyleBackColor = true;
            this.btLoadSchedule.Click += new System.EventHandler(this.btLoadSchedule_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlpTeamB, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 109);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(989, 556);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tlpTeamA);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 548);
            this.panel2.TabIndex = 2;
            // 
            // tlpTeamA
            // 
            this.tlpTeamA.ColumnCount = 1;
            this.tlpTeamA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTeamA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTeamA.Location = new System.Drawing.Point(0, 0);
            this.tlpTeamA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpTeamA.Name = "tlpTeamA";
            this.tlpTeamA.RowCount = 13;
            this.tlpTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamA.Size = new System.Drawing.Size(486, 548);
            this.tlpTeamA.TabIndex = 2;
            // 
            // tlpTeamB
            // 
            this.tlpTeamB.ColumnCount = 1;
            this.tlpTeamB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTeamB.Location = new System.Drawing.Point(498, 4);
            this.tlpTeamB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpTeamB.Name = "tlpTeamB";
            this.tlpTeamB.RowCount = 13;
            this.tlpTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tlpTeamB.Size = new System.Drawing.Size(487, 548);
            this.tlpTeamB.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 44);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(989, 65);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(486, 57);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lbScoreA, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbTeamA, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(486, 57);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lbScoreA
            // 
            this.lbScoreA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbScoreA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbScoreA.Font = new System.Drawing.Font("Agency FB", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScoreA.Location = new System.Drawing.Point(247, 0);
            this.lbScoreA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbScoreA.Name = "lbScoreA";
            this.lbScoreA.Size = new System.Drawing.Size(235, 57);
            this.lbScoreA.TabIndex = 3;
            this.lbScoreA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTeamA
            // 
            this.lbTeamA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTeamA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTeamA.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeamA.Location = new System.Drawing.Point(4, 0);
            this.lbTeamA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTeamA.Name = "lbTeamA";
            this.lbTeamA.Size = new System.Drawing.Size(235, 57);
            this.lbTeamA.TabIndex = 2;
            this.lbTeamA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lbScoreB, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbTeamB, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(498, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(487, 57);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // lbScoreB
            // 
            this.lbScoreB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbScoreB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbScoreB.Font = new System.Drawing.Font("Agency FB", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScoreB.Location = new System.Drawing.Point(4, 0);
            this.lbScoreB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbScoreB.Name = "lbScoreB";
            this.lbScoreB.Size = new System.Drawing.Size(235, 57);
            this.lbScoreB.TabIndex = 3;
            this.lbScoreB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTeamB
            // 
            this.lbTeamB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTeamB.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeamB.Location = new System.Drawing.Point(247, 0);
            this.lbTeamB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTeamB.Name = "lbTeamB";
            this.lbTeamB.Size = new System.Drawing.Size(236, 57);
            this.lbTeamB.TabIndex = 2;
            this.lbTeamB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadMatchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoadMatchControl";
            this.Size = new System.Drawing.Size(989, 665);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btLoadSchedule;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpTeamB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tlpTeamA;
        private System.Windows.Forms.Label lbScheduleName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbScoreA;
        private System.Windows.Forms.Label lbTeamA;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbScoreB;
        private System.Windows.Forms.Label lbTeamB;
    }
}
