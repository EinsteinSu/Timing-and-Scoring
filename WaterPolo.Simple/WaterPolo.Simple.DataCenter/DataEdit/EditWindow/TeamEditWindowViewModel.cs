using System.Collections.Generic;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.DataEdit.EditWindow
{
    public class TeamEditWindowViewModel : EditWindowViewModelBase<Team, TeamEdit>
    {
        public TeamEditWindowViewModel(Team data) : base(data)
        {
        }

        
        public override string Title => "Team Management";
        protected override string Check()
        {
            return string.Empty;
        }


    }
}