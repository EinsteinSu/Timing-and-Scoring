using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Drawing;

namespace ApplicationControlCommon
{
    public class ImageLabel : Label
    {
        public ImageLabel()
        {
            this.BackColor = Color.Transparent;
        }

        private Image _FouceImage;
        /// <summary>
        /// FouceImage
        /// </summary>
        public Image FOUCEIMAGE
        {
            get { return _FouceImage; }
            set { _FouceImage = value; }
        }

        private Image _UnFouceImage;
        /// <summary>
        /// UnFouceImage
        /// </summary>
        public Image UNFOUCEIMAGE
        {
            get { return _UnFouceImage; }
            set { _UnFouceImage = value; }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            this.Image = _FouceImage;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.Image = _UnFouceImage;
        }
    }
}
