using System;
using System.Linq;
using System.Windows;
using Newtonsoft.Json;
using WaterPolo.Simple.DataAccess;
using WaterPolo.Simple.DataCenter.DataEdit.EditWindow;

namespace WaterPolo.Simple.DataCenter.DataEdit
{
    public class ScheduleEdit : DataManagerBase
    {
        public override void Add(object item)
        {
            if (item is ScheduleEditViewModel sev)
            {
                Context.Schedules.Add(sev.Data);
            }

            if (item is Schedule schedule)
            {
                schedule.ScheduleId = 0;
                Context.Schedules.Add(schedule);
            }
            Context.SaveChanges();
        }

        public override void Edit(object item)
        {

        }

        public override object GetItemSource()
        {
            return Context.Schedules.ToList();
        }

        public override object NewItem()
        {
            var schedule = new Schedule
            {
                Name = "Match",
                DisplayName = "Match",
                StartTime = DateTime.Now,
                TeamA = new TeamMatch(),
                TeamB = new TeamMatch()
            };
            var vm = new ScheduleEditViewModel(Context, schedule);
            return vm;
        }

        protected override object ConvertDataFromText(string data)
        {
            return JsonConvert.DeserializeObject<Schedule>(data);
        }

        public override void Delete()
        {
            if (CurrentItem is Schedule schedule)
            {
                Context.Schedules.Remove(schedule);
                Context.SaveChanges();
            }
        }
    }
}