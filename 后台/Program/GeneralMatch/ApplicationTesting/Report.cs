using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ApplicationTesting
{
    public partial class Report : DevExpress.XtraReports.UI.XtraReport
    {
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DataTable _SourceTable;
        /// <summary>
        /// SourceTable
        /// </summary>
        public DataTable SOURCETABLE
        {
            get { return _SourceTable; }
            set { _SourceTable = value; }
        } 

        public Report(DataTable dt)
        {
            _SourceTable = dt;
            this.DataSource = _SourceTable;
            
        }

        private void InitializeComponent()
        {
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.Name = "detailBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1});
            this.Version = "10.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        
    }
}
