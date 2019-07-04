using System;
using System.Windows.Controls;
using System.Windows.Input;
using WaterPolo.Simple.Core.Control.Common;

namespace WaterPolo.Simple.Core.Control.Control
{
    public class NumericEditableButton : Button
    {
        public NumericEditableButton()
        {
            MaxValue = 100;
        }

        public int MaxValue { get; set; }

        public Func<object, object> Increase { get; protected set; }

        public Func<object, object> Decrease { get; protected set; }

        protected override void OnClick()
        {
            base.OnClick();
            Content = Increase != null ? Increase(Content) : ActionHelper.Increase(Content, MaxValue);
        }

        protected override void OnMouseRightButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseRightButtonDown(e);
            Content = Decrease != null ? Decrease(Content) : ActionHelper.Decrease(Content);
        }
    }
}
