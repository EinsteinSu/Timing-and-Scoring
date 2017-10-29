using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationCommon
{
    public interface IEnglish
    {
        string Chinese { get; }
        string English { get; }
        void Change();
    }
}
