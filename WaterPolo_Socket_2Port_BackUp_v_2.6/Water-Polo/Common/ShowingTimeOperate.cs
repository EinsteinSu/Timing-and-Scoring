using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common
{
    public partial class ShowingTimeOperate : ApplicationControlCommon.DialogForm
    {
        PDPShowingTime _pdp;
        public ShowingTimeOperate(string timingType, PDPShowingTime pdp)
        {
            InitializeComponent();

            if (timingType == TimingType.ReadyTime)
                tcShowingTime.SettingTime = ConsoleSettings.ONSETTINGS.READYTIME;
            if (timingType == TimingType.PauseTime)
                tcShowingTime.SettingTime = ConsoleSettings.ONSETTINGS.PAUSETIME;
            this.Text = string.Format("{0}——操作", timingType);

            _pdp = pdp;
            _pdp.SetTime(DateTime.Parse(tcShowingTime.SettingTime).ToString(tcShowingTime.DisplayFormat));
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            tcShowingTime.Start();
        }

        private void ShowingTimeOperate_OkClick()
        {
            _pdp.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void ShowingTimeOperate_CancelClick()
        {
            _pdp.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void tcShowingTime_TextTimingChanged(string timing)
        {
            if (_pdp != null)
                _pdp.SetTime(timing);
        }

        private void tcShowingTime_TimeChanging(int ltime, DateTime dtime)
        {
            if (ltime == 0)
            {
                CloseForm(_pdp);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        public delegate void CloseFormCallback(Form frm);
        public void CloseForm(Form frm)
        {
            if (frm.InvokeRequired)
            {
                CloseFormCallback d = new CloseFormCallback(CloseForm);
                frm.Invoke(d, frm);
            }
            else
                frm.Close();
        }
    }
}
