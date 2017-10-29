using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationCommon
{
    public interface IDataOpreate
    {
        DataTableManager.CreateTable TableManager { get; set; }

        System.Data.DataTable SourceTable { get; set; }

        string FileName { get; }

        System.Data.DataTable CreateTable();

        void RefreshData();

        void Add();

        void Delete();

        void Save();

        void SaveAs();
    }
}
