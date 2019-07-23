using System.Data.Entity;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.New.ViewModels
{
    public class ScheduleDetailsEditViewModel : ISupportParameter
    {
        private object _parameter;
        INavigationService NavigationService { get { return this.GetRequiredService<INavigationService>(); } }

        private ScheduleCollectionViewModel ParentViewModel => this.GetParentViewModel<ScheduleCollectionViewModel>();

        public virtual Schedule Schedule { get; set; }

        public virtual ScheduleTeamEditViewModel TeamA { get; set; }

        public virtual ScheduleTeamEditViewModel TeamB { get; set; }

        public object Parameter
        {
            get => _parameter;
            set
            {
                _parameter = value;
                Schedule = (Schedule)value;
            }
        }

        public void Load()
        {
            TeamA = new ScheduleTeamEditViewModel(ParentViewModel.WpContext, Schedule, CapColor.White);
            TeamB = new ScheduleTeamEditViewModel(ParentViewModel.WpContext, Schedule, CapColor.Blue);

        }

        public void Ok()
        {
            //todo: check the inputs
            if (ParentViewModel.DataEditType == DataEditType.New)
                ParentViewModel.AddSchedule(Schedule);
            else if (ParentViewModel.DataEditType == DataEditType.Edit)
                ParentViewModel.WpContext.Entry(Schedule).State = EntityState.Modified;
            NavigationService.GoBack();
        }

        public void Cancel()
        {
            NavigationService.GoBack();
        }
    }
}