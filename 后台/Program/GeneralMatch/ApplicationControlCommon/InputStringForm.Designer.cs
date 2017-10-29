namespace ApplicationControlCommon
{
    partial class InputStringForm
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
            this.tbText = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tbText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(12, 12);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(280, 21);
            this.tbText.TabIndex = 3;
            // 
            // InputStringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 95);
            this.Controls.Add(this.tbText);
            this.Name = "InputStringForm";
            this.Text = "InputStringForm";
            this.OkClick += new ApplicationControlCommon.DialogForm.OkClickCallback(this.InputStringForm_OkClick);
            this.Controls.SetChildIndex(this.tbText, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tbText.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tbText;
    }
}