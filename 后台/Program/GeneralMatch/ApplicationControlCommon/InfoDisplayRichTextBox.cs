using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationControlCommon
{
    public class InfoDisplayRichTextBox : System.Windows.Forms.RichTextBox
    {
        public InfoDisplayRichTextBox()
        {
        }

        public delegate void AppendTextCallback(bool showTime, string text);
        public void DisplayText(bool showTime, string text)
        {
            if (base.InvokeRequired)
            {
                AppendTextCallback d = new AppendTextCallback(DisplayText);
                base.Invoke(d, showTime, text);
            }
            else
            {
                if (showTime)
                    base.AppendText(string.Format("【{0}】：{1}\r\n", DateTime.Now, text));
                else
                    base.AppendText(string.Format("{0}\r\n", text));
            }
        }
    }
}
