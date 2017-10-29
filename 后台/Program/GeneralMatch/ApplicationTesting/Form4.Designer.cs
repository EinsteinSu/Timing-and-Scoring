namespace ApplicationTesting
{
    partial class Form4
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
            this.myButton1 = new ApplicationControlCommon.MyButton();
            this.SuspendLayout();
            // 
            // myButton1
            // 
            this.myButton1.EnglishText = null;
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.myButton1.FOCUSFONT = null;
            this.myButton1.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.myButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myButton1.Location = new System.Drawing.Point(256, 398);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(75, 23);
            this.myButton1.TabIndex = 4;
            this.myButton1.Text = "myButton1";
            this.myButton1.UNFOCUSFONT = null;
            this.myButton1.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.myButton1.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 728);
            this.Controls.Add(this.myButton1);
            this.FunctionCount = 10;
            this.Name = "Form4";
            this.Text = "Form4";
            this.FunctionClick += new ApplicationControlCommon.SimpleApplicationForm.FunctionClickCallback(this.Form4_FunctionClick);
            this.Controls.SetChildIndex(this.myButton1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private ApplicationControlCommon.MyButton myButton1;
    }
}