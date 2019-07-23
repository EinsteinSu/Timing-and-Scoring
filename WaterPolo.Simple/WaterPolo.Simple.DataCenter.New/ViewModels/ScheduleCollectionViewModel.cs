using System;
using System.Data.Entity;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.New.ViewModels
{
    public class ScheduleCollectionViewModel : EditViewModelBase<Schedule>
    {
        INavigationService NavigationService { get { return this.GetRequiredService<INavigationService>(); } }
        public WaterPoloDataContext WpContext => Context;
        public DataEditType DataEditType { get; private set; }
        public override void Add()
        {
            DataEditType = DataEditType.New;
            var schedule = new Schedule
            {
                Name = "Match",
                DisplayName = "Match",
                StartTime = DateTime.Now,
                TeamA = new TeamMatch { CapColor = CapColor.White },
                TeamB = new TeamMatch { CapColor = CapColor.Blue }
            };
            NavigationService.Navigate("ScheduleDetailsEditView",
                    schedule, this);
        }

        public void AddSchedule(Schedule schedule)
        {
            Context.Schedules.Add(schedule);
        }


        public void Edit()
        {
            DataEditType = DataEditType.Edit;
            var schedule = Context.Schedules.Include(i => i.TeamA).Include(i => i.TeamA.Team)
                .Include(i => i.TeamA.Players).Include(i => i.TeamB).Include(i => i.TeamB.Team)
                .Include(i => i.TeamB.Players).First(f => f.ScheduleId == CurrentItem.ScheduleId);
            NavigationService.Navigate("ScheduleDetailsEditView",
                schedule, this);
        }

        protected override void RemoveItem()
        {
            Context.Schedules.Remove(CurrentItem);
        }

        protected override void RefreshItems()
        {
            Context.Schedules.Load();
            Items = Context.Schedules.Local;
        }
    }
}