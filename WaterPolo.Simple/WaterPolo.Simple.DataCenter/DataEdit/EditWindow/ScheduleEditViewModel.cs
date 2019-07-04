using DevExpress.Mvvm;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.DataEdit.EditWindow
{
    public class ScheduleEditViewModel : EditWindowViewModelBase<Schedule, ScheduleEdit>
    {
        private readonly WaterPoloDataContext _context;
        private TeamMatch _teamA;
        private TeamMatch _teamB;

        public ScheduleEditViewModel(Schedule data, WaterPoloDataContext context) : base(data)
        {
            _context = context;
            ChooseTeamCommand = new DelegateCommand<CapColor>(ChooseTeam, true);
        }

        public override double Height => 500;

        public DelegateCommand<CapColor> ChooseTeamCommand { get; set; }

        public override string Title => "Schedule Edit";

        public TeamMatch TeamA
        {
            get => _teamA;
            set => SetProperty(ref _teamA, value, () => TeamA);
        }

        public TeamMatch TeamB
        {
            get => _teamB;
            set => SetProperty(ref _teamB, value, () => TeamB);
        }

        public void ChooseTeam(CapColor type)
        {
            var data = type == CapColor.White ? Data.TeamA : Data.TeamB;
            var vm = new PlayerSelectEditViewModel(data, _context);
            if (vm.Show())
            {
                data = new TeamMatch
                {
                    TeamId = vm.SelectedTeamId,
                    Players = vm.SelectedPlayers,
                    CapColor = type
                };

                if (type == CapColor.White)
                    Data.TeamA = data;
                else
                    Data.TeamB = data;
                TeamA = Data.TeamA;
                TeamB = Data.TeamB;
            }
        }

        protected override string Check()
        {
            return string.Empty;
        }
    }
}