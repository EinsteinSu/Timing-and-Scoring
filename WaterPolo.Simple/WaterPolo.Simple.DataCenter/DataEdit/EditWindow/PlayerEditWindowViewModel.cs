using System.Collections.Generic;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.DataEdit.EditWindow
{
    public class PlayerEditWindowViewModel : EditWindowViewModelBase<Player, PlayerEdit>
    {
        private readonly WaterPoloDataContext _context;

        public PlayerEditWindowViewModel(Player data, WaterPoloDataContext context) : base(data)
        {
            _context = context;
            //content.cbTeam.ItemsSource = DataService.GetTeams(context);
        }

        public override string Title => "Player";

        public List<Team> Teams => DataService.GetTeams(_context);

        protected override string Check()
        {
            return string.Empty;
        }
    }
}