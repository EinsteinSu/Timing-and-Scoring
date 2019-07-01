using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.DataEdit.EditWindow
{
    public class PlayerEditWindowViewModel : EditWindowViewModelBase<Player, PlayerEdit>
    {
        private readonly WaterPoloDataContext _context;
        private List<Team> _teams;

        public PlayerEditWindowViewModel(Player data, WaterPoloDataContext context) : base(data)
        {
            _context = context;
        }

        public List<Team> Teams
        {
            get
            {
                _teams = DataService.GetTeams(_context);
                return _teams;
            }
            set => _teams = value;
        }


        public override string Title => "Player";
        protected override string Check()
        {
            return string.Empty;

        }
    }
}
