using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationCommon
{
    public interface IXmlHelper
    {
        string FilePath { get; }
        string FileName { get; }
        void Load();
    }
}
