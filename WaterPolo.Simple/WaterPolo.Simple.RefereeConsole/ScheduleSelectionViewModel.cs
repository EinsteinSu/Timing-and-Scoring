using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DevExpress.Mvvm;
using log4net;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.RefereeConsole
{
    public class ScheduleSelectionViewModel : ViewModelBase
    {
        private static readonly ILog Log = LogManager.GetLogger("Schedule Selection");
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
            Schedules = _context.Schedules.Include(i => i.TeamA)
                .Include(i => i.TeamA.Team).Include(i => i.TeamB).Include(i => i.TeamB.Team).ToList();
            Log.Info($"Schedule Count");
            RaisePropertiesChanged("Schedules");
        }
    }
}