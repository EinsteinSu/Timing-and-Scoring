namespace AthleticsParamManager
{
    partial class CameraToPhoto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraToPhoto));
            this.plPhoto = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btCancel = new ApplicationControlCommon.MyButton();
            this.btSelect = new ApplicationControlCommon.MyButton();
            this.btCamera = new ApplicationControlCommon.MyButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btClear = new ApplicationControlCommon.MyButton();
            this.SuspendLayout();
            // 
            // plPhoto
            // 
            this.plPhoto.Location = new System.Drawing.Point(12, 12);
            this.plPhoto.Name = "plPhoto";
            this.plPhoto.Size = new System.Drawing.Size(232, 246);
            this.plPhoto.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(250, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(238, 316);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.EnglishText = "Close";
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancel.FOCUSFONT = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCancel.FOCUSFONTCOLOR = System.Drawing.SystemColors.ControlText;
            this.btCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.Location = new System.Drawing.Point(413, 349);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "关    闭";
            this.btCancel.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCancel.UNFOCUSFONTCOLOR = System.Drawing.SystemColors.ControlText;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSelect
            // 
            this.btSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelect.EnglishText = "Setting";
            this.btSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSelect.FOCUSFONT = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSelect.FOCUSFONTCOLOR = System.Drawing.SystemColors.ControlText;
            this.btSelect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSelect.Location = new System.Drawing.Point(332, 349);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(75, 23);
            this.btSelect.TabIndex = 6;
            this.btSelect.Text = "选    择";
            this.btSelect.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSelect.UNFOCUSFONTCOLOR = System.Drawing.SystemColors.ControlText;
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // btCamera
            // 
            this.btCamera.EnglishText = null;
            this.btCamera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCamera.FOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCamera.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btCamera.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCamera.Image = ((System.Drawing.Image)(resources.GetObject("btCamera.Image")));
            this.btCamera.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCamera.Location = new System.Drawing.Point(12, 264);
            this.btCamera.Name = "btCamera";
            this.btCamera.Size = new System.Drawing.Size(113, 64);
            this.btCamera.TabIndex = 7;
            this.btCamera.Text = "拍    照";
            this.btCamera.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCamera.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCamera.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btCamera.UseVisualStyleBackColor = true;
            this.btCamera.Click += new System.EventHandler(this.btCamera_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(128, 128);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btClear
            // 
            this.btClear.EnglishText = null;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClear.FOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClear.FOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btClear.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClear.Image = ((System.Drawing.Image)(resources.GetObject("btClear.Image")));
            this.btClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btClear.Location = new System.Drawing.Point(131, 264);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(113, 64);
            this.btClear.TabIndex = 8;
            this.btClear.Text = "清除记录";
            this.btClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btClear.UNFOCUSFONT = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClear.UNFOCUSFONTCOLOR = System.Drawing.Color.Empty;
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // CameraToPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 384);
            this.ControlBox = false;
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCamera);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.plPhoto);
            this.Controls.Add(this.listView1);
            this.Name = "CameraToPhoto";
            this.ShowInTaskbar = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CameraToPhoto";
            this.Load += new System.EventHandler(this.CameraToPhoto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plPhoto;
        private System.Windows.Forms.ListView listView1;
        private ApplicationControlCommon.MyButton btCancel;
        private ApplicationControlCommon.MyButton btSelect;
        private ApplicationControlCommon.MyButton btCamera;
        private System.Windows.Forms.ImageList imageList1;
        private ApplicationControlCommon.MyButton btClear;
    }
}