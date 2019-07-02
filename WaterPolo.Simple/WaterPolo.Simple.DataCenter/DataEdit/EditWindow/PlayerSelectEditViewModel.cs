using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DevExpress.Mvvm;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.DataEdit.EditWindow
{
    public class PlayerSelectEditViewModel : ViewModelBase, IDialogWindow
    {
        private readonly TeamMatch _teamMatch;
        private readonly WaterPoloDataContext _context;

        public PlayerSelectEditViewModel(TeamMatch teamMatch, WaterPoloDataContext context)
        {
            _teamMatch = teamMatch;
            _context = context;
            _selectedTeam = teamMatch.Team;
            Players = teamMatch.Players.ToList();
        }

        private Team _selectedTeam;
        public string Title => "Player Selection";
        public FrameworkElement Content => new PlayerSelect();

        public Team SelectedTeam
        {
            get => _selectedTeam;
            set
            {
                SetProperty(ref _selectedTeam, value, () => SelectedTeam);
                if (value != null)
                {
                    Players = DataService.GetPlayersByTeamId(_context, value.TeamId);
                }
            }
        }

        public List<Player> Players { get; set; }

        //todo: check quantity
        public bool Confirm()
        {
            return true;
        }

        public bool Cancel()
        {
            return true;
        }
    }
}