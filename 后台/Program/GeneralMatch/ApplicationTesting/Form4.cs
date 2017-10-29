using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApplicationTesting
{
    public partial class Form4 : ApplicationControlCommon.EncryptSimpleApplicationForm
    {
        public Form4()
        {
            InitializeComponent();
            TitleLabel.Text = "Testing";
            for(int i=0;i<10;i++)
            {
                AddFunctionButton(12F, "Test" + i.ToString(), ContentAlignment.MiddleCenter, i, null, ContentAlignment.MiddleCenter);
            }
        }

        private void Form4_FunctionClick(string functionName)
        {
            switch (functionName)
            {
                case "Test0":
                    MessageBox.Show("S");
                    break;
            }
        }
    }
}
