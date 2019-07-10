using WaterPolo.Simple.Core.Control.Common;

namespace WaterPolo.Simple.Core.Control.Control
{
    public class TwentySecondsEditableButton : NumericEditableButton
    {
        public TwentySecondsEditableButton()
        {
            Decrease = ActionHelper.DecreaseTwentySeconds;
        }

        protected override void OnClick()
        {
            base.OnClick();
            Content = 0;
        }
    }
}