using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AthleticsParamManager
{
    public partial class CameraToPhoto : ApplicationControlCommon.DialogBaseForm
    {
        
        ApplicationCommon.Camera c;
        public Image SelectorPhoto { get; set; }

        public CameraToPhoto()
        {
            InitializeComponent();
            if (c == null)
            {
                using (DevExpress.Utils.WaitDialogForm wfm = new DevExpress.Utils.WaitDialogForm("正在初始化摄像头",
                    "请稍后 ..."))
                {
                    c = new ApplicationCommon.Camera(plPhoto.Handle, 0, 0, plPhoto.Width, plPhoto.Height);
                }
                c.Start();
            }
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        new public void Dispose()
        {
            c.Stop();
        }

        private void CameraToPhoto_Load(object sender, EventArgs e)
        {

        }

        int i = 0;
        private void btCamera_Click(object sender, EventArgs e)
        {
            ApplicationCommon.SoundHelper.PlaySound("Camera.wav");
            imageList1.Images.Add(ApplicationCommon.BinaryHelper.ByteToImage( c.GetPhoto(),
                string.Format(@"{0}\{1}.jpg",ApplicationCommon.DirectoryHelper.TempDirectory,Guid.NewGuid().ToString())));
            listView1.Items.Add(new ListViewItem(i.ToString(),i));
            for (int j = 0; j < listView1.Items.Count; j++)
                listView1.Items[j].Selected = false;
            listView1.Focus();
            listView1.Items[i].Selected = true;
            listView1.Items[i].EnsureVisible();
            i++;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        public delegate void SelectPhotoCallback(Image img);
        public event SelectPhotoCallback SelectPhoto;
        private void btSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems[0] != null)
                {
                    SelectorPhoto = imageList1.Images[listView1.SelectedItems[0].ImageIndex];
                    if (SelectPhoto != null)
                        SelectPhoto(SelectorPhoto);
                    this.Hide();
                }
                else
                    MessageBox.Show("请选择一张照片！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("照片选择错误：" + ex.Message);
            }
        }
    }
}
