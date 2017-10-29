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
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            SystemManager.Options frm = new SystemManager.Options();
            frm.ShowDialog();
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            pcFunction.ShowControl(typeof(SystemManager.UserManager), DockStyle.Fill);
        }

        private void myButton3_Click(object sender, EventArgs e)
        {
            pcFunction.ShowControl(typeof(SystemManager.FunctionManager), DockStyle.Fill);
        }

        private void myButton4_Click(object sender, EventArgs e)
        {
            pcFunction.ShowControl(typeof(SystemManager.FunctionImageManager), DockStyle.Fill);
        }

        private void myButton5_Click(object sender, EventArgs e)
        {
            pcFunction.ShowControl(typeof(SystemManager.RoleManager), DockStyle.Fill);
        }


    }
}
