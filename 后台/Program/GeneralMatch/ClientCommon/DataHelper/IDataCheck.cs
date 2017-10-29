using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public interface IDataCheck
    {
        bool DataCheck(out string errMsg);
    }
}
