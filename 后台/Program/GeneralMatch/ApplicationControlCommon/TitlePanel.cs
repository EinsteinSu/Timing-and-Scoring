using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Drawing;

namespace ApplicationControlCommon
{
    public class TitlePanel : Panel
    {
        public TitlePanel()
        {
            _StartColor = base.BackColor;
            _EndColor = base.BackColor;
        }

        #region 渐变色
        private Color _StartColor;
        /// <summary>
        /// StartColor
        /// </summary>
        public Color STARTCOLOR
        {
            get { return _StartColor; }
            set { _StartColor = value; }
        }

        private Color _EndColor;
        /// <summary>
        /// EndColor
        /// </summary>
        public Color ENDCOLOR
        {
            get { return _EndColor; }
            set { _EndColor = value; }
        }

        private float _ColorAngle;
        /// <summary>
        /// ColorAngle
        /// </summary>
        public float COLORANGLE
        {
            get { return _ColorAngle; }
            set { _ColorAngle = value; this.Invalidate(); }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //Rectangle rBackground = new Rectangle(0, 0, this.Width, this.Height);
            //System.Drawing.Drawing2D.LinearGradientBrush bBackground = new System.Drawing.Drawing2D.LinearGradientBrush(rBackground, _StartColor, _EndColor, _ColorAngle);
            //g.FillRectangle(bBackground, rBackground);
            //bBackground.Dispose();
        }
        #endregion
    }
}
