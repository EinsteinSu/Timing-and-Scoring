using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public interface ISqlOperateLog
    {
        /// <summary>
        /// GUID
        /// </summary>
        string TableGuid { get; }
        /// <summary>
        /// 操作类型
        /// </summary>
        SystemOperateType OperateType { get; set; }
        /// <summary>
        /// 操作表
        /// </summary>
        /// <returns></returns>
        String OperateTable { get; }
        /// <summary>
        /// 备注
        /// </summary>
        String Remark { get; }
    }
}
