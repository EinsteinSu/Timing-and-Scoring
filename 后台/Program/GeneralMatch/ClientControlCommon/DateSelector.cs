using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientControlCommon
{
    public partial class DateSelector : ApplicationControlCommon.DialogForm
    {
        public DateTime StartDate
        {
            get
            {
                return (DateTime)dtStart.EditValue;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return (DateTime)dtEnd.EditValue;
            }
        }

        public DateSelector()
        {
            InitializeComponent();
            dtStart.EditValue = DateTime.Now.AddDays(-1);
            dtEnd.EditValue = DateTime.Now;
        }

        private void DateSelector_OkClick()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
