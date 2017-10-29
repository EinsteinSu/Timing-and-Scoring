namespace ApplicationTesting
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.myButton1 = new ApplicationControlCommon.MyButton();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ActiveX%20Cache.png");
            this.imageList1.Images.SetKeyName(1, "Administrative%20Tools.png");
            this.imageList1.Images.SetKeyName(2, "Audio%20CD.png");
            this.imageList1.Images.SetKeyName(3, "Bitmap%20Image.png");
            this.imageList1.Images.SetKeyName(4, "Bluetooth.png");
            this.imageList1.Images.SetKeyName(5, "Burn.png");
            this.imageList1.Images.SetKeyName(6, "CD.png");
            this.imageList1.Images.SetKeyName(7, "CD-ROM%20Drive.png");
            this.imageList1.Images.SetKeyName(8, "Chat.png");
            this.imageList1.Images.SetKeyName(9, "Clipboard.png");
            this.imageList1.Images.SetKeyName(10, "Configuration%20Settings.png");
            this.imageList1.Images.SetKeyName(11, "Control%20Panel.png");
            this.imageList1.Images.SetKeyName(12, "Default%20Icon.png");
            this.imageList1.Images.SetKeyName(13, "Desktop.png");
            this.imageList1.Images.SetKeyName(14, "Dial-Up%20Networking.png");
            this.imageList1.Images.SetKeyName(15, "Documents.png");
            this.imageList1.Images.SetKeyName(16, "E-Mail.png");
            this.imageList1.Images.SetKeyName(17, "Entire%20Network.png");
            this.imageList1.Images.SetKeyName(18, "Explorer.png");
            // 
            // myButton1
            // 
            this.myButton1.EnglishText = null;
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.myButton1.FOCUSFONT = null;
            this.myButton1.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.myButton1.Image = ((System.Drawing.Image)(resources.GetObject("myButton1.Image")));
            this.myButton1.Location = new System.Drawing.Point(61, 195);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(165, 120);
            this.myButton1.TabIndex = 0;
            this.myButton1.UNFOCUSFONT = null;
            this.myButton1.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.myButton1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 436);
            this.Controls.Add(this.myButton1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private ApplicationControlCommon.MyButton myButton1;
    }
}