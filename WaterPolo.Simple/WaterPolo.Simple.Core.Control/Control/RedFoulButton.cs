using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WaterPolo.Simple.Core.Control.Control
{
    public class RedFoulButton : Button
    {
        public static string Dot = "1";
        protected override void OnClick()
        {
            base.OnClick();
            if (Content == null || string.IsNullOrEmpty(Content.ToString()))
                Content = Dot;
            else
            {
                Content = string.Empty;
            }
        }
    }
}
