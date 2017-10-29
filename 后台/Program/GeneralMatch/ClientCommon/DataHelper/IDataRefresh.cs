using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public interface IDataRefresh
    {
        /// <summary>
        /// 需要操作的数据表
        /// </summary>
        System.Data.DataTable[] OperateTables { get; }

        /// <summary>
        /// 刷新数据
        /// </summary>
        void RefreshData();

        /// <summary>
        /// 保存数据
        /// </summary>
        void SaveData();
    }
}
