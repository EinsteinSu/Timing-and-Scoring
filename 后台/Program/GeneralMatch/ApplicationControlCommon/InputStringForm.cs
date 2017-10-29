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
    public partial class InputStringForm : DialogForm
    {
        public InputStringForm()
        {
            InitializeComponent();
        }

        public string InputString
        {
            get
            {
                return tbText.Text;
            }
        }

        private void InputStringForm_OkClick()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
