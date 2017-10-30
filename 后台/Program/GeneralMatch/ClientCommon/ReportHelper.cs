using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public static class ReportHelper
    {
        public static void ShowPrint(string fileName, System.Data.DataTable dt)
        {
            using (DevExpress.Utils.WaitDialogForm wfm = new DevExpress.Utils.WaitDialogForm("正在加载报表", "请稍后 ..."))
            {
                DevExpress.XtraReports.UI.XtraReport r = DevExpress.XtraReports.UI.XtraReport.FromFile(ApplicationCommon.DirectoryHelper.ReportDirectory + fileName, true);
                r.DataSource = dt;
                //r.ShowPreview();
            }
        }

        public static void ShowDesign(string fileName, System.Data.DataTable dt)
        {
            using (DevExpress.Utils.WaitDialogForm wfm = new DevExpress.Utils.WaitDialogForm("正在加载报表", "请稍后 ..."))
            {
                DevExpress.XtraReports.UI.XtraReport r = DevExpress.XtraReports.UI.XtraReport.FromFile(ApplicationCommon.DirectoryHelper.ReportDirectory + fileName, true);
                r.DataSource = dt;
                //r.ShowDesigner();
            }
        }

        public static void ShowDesign(string fileName,System.Data.DataSet ds)
        {
            using (DevExpress.Utils.WaitDialogForm wfm = new DevExpress.Utils.WaitDialogForm("正在加载报表", "请稍后 ..."))
            {
                DevExpress.XtraReports.UI.XtraReport r = DevExpress.XtraReports.UI.XtraReport.FromFile(ApplicationCommon.DirectoryHelper.ReportDirectory + fileName, true);
                r.DataSource = ds;
                //r.ShowDesigner();
            }
        }
    }
}
