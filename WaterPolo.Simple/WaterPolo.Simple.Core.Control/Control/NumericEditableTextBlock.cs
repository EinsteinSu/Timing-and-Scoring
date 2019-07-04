using System.Windows.Controls;
using System.Windows.Input;
using WaterPolo.Simple.Core.Control.Common;

namespace WaterPolo.Simple.Core.Control.Control
{
    public class NumericEditableTextBlock : TextBlock
    {
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            Text = ActionHelper.Increase(Text).ToString();
        }

        protected override void OnMouseRightButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseRightButtonDown(e);
            Text = ActionHelper.Decrease(Text).ToString();
        }
    }
}