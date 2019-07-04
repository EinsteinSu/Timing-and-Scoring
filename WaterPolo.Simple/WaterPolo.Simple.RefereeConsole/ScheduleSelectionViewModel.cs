using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.RefereeConsole
{
    public class ScheduleSelectionViewModel
    {
        public ScheduleSelectionViewModel()
        {

        }

        protected void Load()
        {
            var context = new WaterPoloDataContext();
            Schedules = context.Schedules.ToList();
        }

        public static ScheduleSelectionViewModel Create()
        {
            return ViewModelSource.Create(() => new ScheduleSelectionViewModel());
        }

        public virtual List<Schedule> Schedules { get; set; }

        public virtual Schedule SelectedSchedule { get; set; }
    }
}
