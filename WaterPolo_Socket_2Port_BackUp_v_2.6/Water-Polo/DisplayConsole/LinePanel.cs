using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DisplayConsole
{
    public class LinePanel : System.Windows.Forms.Panel
    {
        public LinePanel()
        {
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                g.DrawLine(new Pen(Color.Red, 10), new Point(0, this.Height / 2), new Point(this.Width, this.Height / 2));
            }
        }
    }
}
