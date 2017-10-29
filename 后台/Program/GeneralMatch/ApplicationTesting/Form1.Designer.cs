namespace ApplicationTesting
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.myButton1 = new ApplicationControlCommon.MyButton();
            this.tlpTools = new System.Windows.Forms.TableLayoutPanel();
            this.myButton5 = new ApplicationControlCommon.MyButton();
            this.myButton2 = new ApplicationControlCommon.MyButton();
            this.myButton3 = new ApplicationControlCommon.MyButton();
            this.myButton4 = new ApplicationControlCommon.MyButton();
            this.pcFunction = new ApplicationControlCommon.ParentControl();
            this.tlpTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // myButton1
            // 
            this.myButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton1.EnglishText = null;
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.myButton1.FOCUSFONT = null;
            this.myButton1.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.myButton1.Location = new System.Drawing.Point(3, 3);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(129, 83);
            this.myButton1.TabIndex = 0;
            this.myButton1.Text = "setting";
            this.myButton1.UNFOCUSFONT = null;
            this.myButton1.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // tlpTools
            // 
            this.tlpTools.ColumnCount = 1;
            this.tlpTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTools.Controls.Add(this.myButton5, 0, 4);
            this.tlpTools.Controls.Add(this.myButton2, 0, 1);
            this.tlpTools.Controls.Add(this.myButton1, 0, 0);
            this.tlpTools.Controls.Add(this.myButton3, 0, 2);
            this.tlpTools.Controls.Add(this.myButton4, 0, 3);
            this.tlpTools.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpTools.Location = new System.Drawing.Point(0, 0);
            this.tlpTools.Name = "tlpTools";
            this.tlpTools.RowCount = 5;
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTools.Size = new System.Drawing.Size(135, 445);
            this.tlpTools.TabIndex = 1;
            // 
            // myButton5
            // 
            this.myButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton5.EnglishText = null;
            this.myButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.myButton5.FOCUSFONT = null;
            this.myButton5.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.myButton5.Location = new System.Drawing.Point(3, 359);
            this.myButton5.Name = "myButton5";
            this.myButton5.Size = new System.Drawing.Size(129, 83);
            this.myButton5.TabIndex = 4;
            this.myButton5.Text = "Role manager";
            this.myButton5.UNFOCUSFONT = null;
            this.myButton5.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.myButton5.UseVisualStyleBackColor = true;
            this.myButton5.Click += new System.EventHandler(this.myButton5_Click);
            // 
            // myButton2
            // 
            this.myButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton2.EnglishText = null;
            this.myButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.myButton2.FOCUSFONT = null;
            this.myButton2.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.myButton2.Location = new System.Drawing.Point(3, 92);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(129, 83);
            this.myButton2.TabIndex = 1;
            this.myButton2.Text = "User manager";
            this.myButton2.UNFOCUSFONT = null;
            this.myButton2.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // myButton3
            // 
            this.myButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton3.EnglishText = null;
            this.myButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.myButton3.FOCUSFONT = null;
            this.myButton3.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.myButton3.Location = new System.Drawing.Point(3, 181);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(129, 83);
            this.myButton3.TabIndex = 2;
            this.myButton3.Text = "Function manager";
            this.myButton3.UNFOCUSFONT = null;
            this.myButton3.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.myButton3.UseVisualStyleBackColor = true;
            this.myButton3.Click += new System.EventHandler(this.myButton3_Click);
            // 
            // myButton4
            // 
            this.myButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.myButton4.EnglishText = null;
            this.myButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.myButton4.FOCUSFONT = null;
            this.myButton4.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.myButton4.Location = new System.Drawing.Point(3, 270);
            this.myButton4.Name = "myButton4";
            this.myButton4.Size = new System.Drawing.Size(129, 83);
            this.myButton4.TabIndex = 3;
            this.myButton4.Text = "Image manager";
            this.myButton4.UNFOCUSFONT = null;
            this.myButton4.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.myButton4.UseVisualStyleBackColor = true;
            this.myButton4.Click += new System.EventHandler(this.myButton4_Click);
            // 
            // pcFunction
            // 
            this.pcFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcFunction.Location = new System.Drawing.Point(135, 0);
            this.pcFunction.Name = "pcFunction";
            this.pcFunction.Size = new System.Drawing.Size(630, 445);
            this.pcFunction.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 445);
            this.Controls.Add(this.pcFunction);
            this.Controls.Add(this.tlpTools);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ApplicationControlCommon.MyButton myButton1;
        private System.Windows.Forms.TableLayoutPanel tlpTools;
        private ApplicationControlCommon.MyButton myButton2;
        private ApplicationControlCommon.ParentControl pcFunction;
        private ApplicationControlCommon.MyButton myButton3;
        private ApplicationControlCommon.MyButton myButton4;
        private ApplicationControlCommon.MyButton myButton5;
    }
}

