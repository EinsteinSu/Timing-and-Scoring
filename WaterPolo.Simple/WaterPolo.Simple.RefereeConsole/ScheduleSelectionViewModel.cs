using System.Collections.Generic;
using System.Linq;
using DevExpress.Mvvm;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.RefereeConsole
{
    public class ScheduleSelectionViewModel : ViewModelBase
    {
        private readonly WaterPoloDataContext _context;
        private Schedule _selectedSchedule;

        public ScheduleSelectionViewModel(WaterPoloDataContext context)
        {
            _context = context;
            LoadCommand = new DelegateCommand(Load, true);
        }

        public DelegateCommand LoadCommand { get; set; }


        public List<Schedule> Schedules { get; set; }

        public Schedule SelectedSchedule
        {
            get => _selectedSchedule;
            set => SetProperty(ref _selectedSchedule, value, () => SelectedSchedule);
        }

        protected void Load()
        {
            Schedules = _context.Schedules.ToList();
            RaisePropertiesChanged("Schedules");
        }
    }
}