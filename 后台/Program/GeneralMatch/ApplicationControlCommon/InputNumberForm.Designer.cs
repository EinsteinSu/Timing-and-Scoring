namespace ApplicationControlCommon
{
    partial class InputNumberForm
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
            this.ceNumber = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ceNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ceNumber
            // 
            this.ceNumber.Location = new System.Drawing.Point(13, 13);
            this.ceNumber.Name = "ceNumber";
            this.ceNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ceNumber.Properties.NullText = "0";
            this.ceNumber.Size = new System.Drawing.Size(328, 21);
            this.ceNumber.TabIndex = 3;
            // 
            // InputNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 95);
            this.Controls.Add(this.ceNumber);
            this.Name = "InputNumberForm";
            this.Text = "InputNumberForm";
            this.OkClick += new ApplicationControlCommon.DialogForm.OkClickCallback(this.InputNumberForm_OkClick);
            this.Controls.SetChildIndex(this.ceNumber, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ceNumber.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CalcEdit ceNumber;
    }
}