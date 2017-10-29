using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientControlCommon
{
    public partial class FunctionAttribute : ApplicationControlCommon.DialogBaseForm
    {
        public FunctionAttribute(ClientCommon.Functions f)
        {
            InitializeComponent();
            lbName.Text = f.NAME;
            lbNameEn.Text = f.NAME_EN;
            lbMemo.Text = f.MEMO;
            pbImage.Image = ClientCommon.SystemImages.GetImage(f.IMAGEINDEX);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
