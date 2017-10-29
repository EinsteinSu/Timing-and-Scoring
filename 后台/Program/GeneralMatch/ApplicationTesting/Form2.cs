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
    public partial class Form2 : Form
    {
        Point oldPoint = Point.Empty;
        int[] heights;
        int[] widths;

        public Form2()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            heights = new int[tableLayoutPanel1.RowCount];
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
              
            }
            heights = tableLayoutPanel1.GetRowHeights();
            MessageBox.Show(tableLayoutPanel1.GetRowHeights().Length.ToString());
            widths = tableLayoutPanel1.GetColumnWidths();

        }

        private void tableLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            Point newPoint = this.PointToClient(new Point(e.X - oldPoint.X, e.Y - oldPoint.Y));
            int c = GetRowOrColumn(newPoint.X, widths);
            int r = GetRowOrColumn(newPoint.Y, heights);
            System.Diagnostics.Debug.WriteLine("r=" + r + "/" + "c=" + c);
            Label l = e.Data.GetData(typeof(System.Windows.Forms.Label)) as Label;
            tableLayoutPanel1.SetRow(l, r);
            tableLayoutPanel1.SetColumn(l, c);
            tableLayoutPanel1.ResumeLayout();

        }

        private void tableLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.Windows.Forms.Label)))
                e.Effect = DragDropEffects.All;

        }

        private void tableLayoutPanel1_DragOver(object sender, DragEventArgs e)
        {
            Label l = e.Data.GetData(typeof(System.Windows.Forms.Label)) as Label;
            l.Location = this.PointToClient(new Point(e.X - oldPoint.X, e.Y - oldPoint.Y));
            l.BringToFront();

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            tableLayoutPanel1.ResumeLayout();

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.AllowDrop = true;
            oldPoint = new Point(e.X, e.Y);
            ((Control)sender).DoDragDrop(sender, DragDropEffects.All);

        }

        int GetRowOrColumn(int x, int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (x >= sum && x <= sum + arr[i])
                {
                    return i;
                }
                sum += arr[i];
            }
            return 0;
        }
    }
}
