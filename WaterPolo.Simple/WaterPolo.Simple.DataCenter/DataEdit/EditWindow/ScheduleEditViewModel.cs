using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.DataEdit.EditWindow
{
    public class ScheduleEditViewModel : EditWindowViewModelBase<Schedule, ScheduleEdit>
    {
        private readonly WaterPoloDataContext _context;

        public ScheduleEditViewModel(Schedule data, WaterPoloDataContext context) : base(data)
        {
            _context = context;
            ChooseTeamCommand = new DelegateCommand<string>(ChooseTeam, true);
        }

        public override double Height => 500;

        public DelegateCommand<string> ChooseTeamCommand { get; set; }

        public void ChooseTeam(string type)
        {
            Console.Write(type);
        }

        public override string Title => "Schedule Edit";
        protected override string Check()
        {
            return string.Empty;
        }
    }
}
