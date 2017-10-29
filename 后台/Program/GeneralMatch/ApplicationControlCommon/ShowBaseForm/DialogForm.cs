using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApplicationControlCommon
{
    public partial class DialogForm : DialogBaseForm
    {
        public DialogForm()
        {
            InitializeComponent();
        }

        public delegate void OkClickCallback();
        public event OkClickCallback OkClick;
        private void btOk_Click(object sender, EventArgs e)
        {
            if (OkClick != null)
                OkClick();
        }

        public delegate void CancelClickCallback();
        public event CancelClickCallback CancelClick;
        private void btCancel_Click(object sender, EventArgs e)
        {
            if(CancelClick != null)
                CancelClick();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
