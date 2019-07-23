using System;
using System.Data.Entity;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using WaterPolo.Simple.DataAccess;
using WaterPolo.Simple.DataCenter.New.ViewModels.Models;

namespace WaterPolo.Simple.DataCenter.New.ViewModels
{
    public class ScheduleCollectionViewModel : EditViewModelBase<Schedule, ScheduleIE>
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

        protected override void AddItem(Schedule item)
        {
            Context.Schedules.Add(item);
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

        protected override Schedule ConvertFromImportData(ScheduleIE importData)
        {
            return new Schedule
            {
                DisplayName = importData.DisplayName,
                Name = importData.Name,
                StartTime = importData.StartTime
            };
        }

        protected override ScheduleIE ConvertToExportData(Schedule data)
        {
            return new ScheduleIE
            {
                DisplayName = data.DisplayName,
                Name = data.Name,
                StartTime = data.StartTime
            };
        }

        protected override void RefreshItems()
        {
            Context.Schedules.Load();
            Items = Context.Schedules.Local;
        }
    }
}