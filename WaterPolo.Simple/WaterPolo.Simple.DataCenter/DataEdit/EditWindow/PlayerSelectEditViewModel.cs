using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DevExpress.Mvvm;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.DataEdit.EditWindow
{
    public class PlayerSelectEditViewModel : ViewModelBase, IDialogWindow
    {
        private readonly WaterPoloDataContext _context;
        private readonly PlayerSelect _playerSelect;
        private readonly TeamMatch _teamMatch;
        private List<Player> _players;
        private List<Player> _selectedPlayers;

        private int _selectedTeamId;

        public PlayerSelectEditViewModel(TeamMatch teamMatch, WaterPoloDataContext context)
        {
            _teamMatch = teamMatch;
            _context = context;
            SelectedTeamId = teamMatch?.TeamId ?? 0;
            SelectedPlayers = teamMatch?.Players.ToList();
            _playerSelect = new PlayerSelect();
        }

        public double Height => 300;

        public double Width => 300;

        public int SelectedTeamId
        {
            get => _selectedTeamId;
            set
            {
                SetProperty(ref _selectedTeamId, value, () => SelectedTeamId);
                if (SelectedTeamId > 0)
                    Players = DataService.GetPlayersByTeamId(_context, value);
            }
        }

        public List<Player> SelectedPlayers
        {
            get => _selectedPlayers;
            set => SetProperty(ref _selectedPlayers, value, () => SelectedPlayers);
        }

        public List<Team> Teams => DataService.GetTeams(_context);

        public List<Player> Players
        {
            get => _players;
            set => SetProperty(ref _players, value, () => Players);
        }

        public string Title => "Player Selection";
        public FrameworkElement Content => _playerSelect;

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