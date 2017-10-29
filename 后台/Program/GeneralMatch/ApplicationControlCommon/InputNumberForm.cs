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
    public partial class InputNumberForm : ApplicationControlCommon.DialogForm
    {
        Type _numberType;
        public InputNumberForm(Type numberType)
        {
            InitializeComponent();
            _numberType = numberType;
            if (_numberType == typeof(int))
                ceNumber.Properties.NullText = "0";
            else
                ceNumber.Properties.NullText = "0.0";
        }

        public int NumberOfInt
        {
            get
            {
                return int.Parse(ceNumber.Text);
            }
        }

        public double NumberOfDouble
        {
            get
            {
                return double.Parse(ceNumber.Text);
            }
        }

        public float NumberOfFloat
        {
            get
            {
                return float.Parse(ceNumber.Text);
            }
        }

        private void InputNumberForm_OkClick()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
