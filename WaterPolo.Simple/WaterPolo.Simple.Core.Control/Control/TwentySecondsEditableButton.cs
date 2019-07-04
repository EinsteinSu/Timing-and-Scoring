using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterPolo.Simple.Core.Control.Common;

namespace WaterPolo.Simple.Core.Control.Control
{
    public class TwentySecondsEditableButton : NumericEditableButton
    {
        public TwentySecondsEditableButton()
        {
            Decrease = ActionHelper.DecreaseTwentySeconds;
        }
    }
}
