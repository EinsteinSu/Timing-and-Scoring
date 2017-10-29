using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationControlCommon
{
    public class MyButton : System.Windows.Forms.Button, ApplicationCommon.IEnglish
    {
        #region attributes
        private System.Drawing.Font _UnFocusFont;
        /// <summary>
        /// UnFocusFont
        /// </summary>
        public System.Drawing.Font UNFOCUSFONT
        {
            get { return _UnFocusFont; }
            set { _UnFocusFont = value; }
        }

        private System.Drawing.Font _FocusFont;
        /// <summary>
        /// FocusFont
        /// </summary>
        public System.Drawing.Font FOCUSFONT
        {
            get { return _FocusFont; }
            set { _FocusFont = value; }
        }

        private System.Drawing.Color _FocusFontColor;
        /// <summary>
        /// FocusColor
        /// </summary>
        public System.Drawing.Color FOCUSFONTCOLOR
        {
            get { return _FocusFontColor; }
            set { _FocusFontColor = value; }
        }

        private System.Drawing.Color _UnFocusFontColor;
        /// <summary>
        /// UnFocusColor
        /// </summary>
        public System.Drawing.Color UNFOCUSFONTCOLOR
        {
            get { return _UnFocusFontColor; }
            set { _UnFocusFontColor = value; }
        }
        #endregion

        public MyButton()
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Font = _UnFocusFont;
            //this.Font = _FocusFont;
            this.ForeColor = _UnFocusFontColor;
            //this.ForeColor = _FocusFontColor;
        }

        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs mevent)
        {
            base.OnMouseMove(mevent);
            this.Font = _FocusFont;
            this.ForeColor = _FocusFontColor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Font = _UnFocusFont;
            this.ForeColor = _UnFocusFontColor;
        }

        string _engLishText;
        public string EnglishText
        {
            get
            {
                return _engLishText;
            }
            set
            {
                _engLishText = value;
            }
        }

        public string Chinese
        {
            get { return this.Text; }
        }

        public string English
        {
            get { return EnglishText; }
        }

        public void Change()
        {
            if (ApplicationCommon.SystemLanguage.ONSYSTEMLANGUAGE.ONLANGUAGE == ApplicationCommon.Language.ChineseSimplified)
                this.Text = Chinese;
            else
                this.Text = English;
        }
    }
}
