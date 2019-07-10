using System.Collections.Generic;
using System.Linq;
using DevExpress.Mvvm;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.DataEdit.EditWindow
{
    public class ScheduleEditViewModel : ViewModelBase
    {
        private readonly WaterPoloDataContext _context;
        private Schedule _data;
        private Team _selectedTeamA;
        private Team _selectedTeamB;
        private List<Player> _teamAPlayers;
        private List<Player> _teamBPlayers;
        private List<Player> _selectedTeamAPlayers;
        private List<Player> _selectedTeamBPlayers;

        public ScheduleEditViewModel(WaterPoloDataContext context, Schedule data)
        {
            _context = context;
            Data = data;
        }

        public Schedule Data
        {
            get => _data;
            set => _data = value;
        }

        public Team SelectedTeamA
        {
            get => _selectedTeamA;
            set
            {
                SetProperty(ref _selectedTeamA, value, () => SelectedTeamA);
                TeamAPlayers = DataService.GetPlayersByTeamId(_context, value.TeamId).OrderBy(o => o.OrderNumber).ToList();
                Data.TeamA.Team = value;
            }
        }

        public List<Player> TeamAPlayers
        {
            get => _teamAPlayers;
            set => SetProperty(ref _teamAPlayers, value, () => TeamAPlayers);
        }


        public Team SelectedTeamB
        {
            get => _selectedTeamB;
            set
            {
                SetProperty(ref _selectedTeamB, value, () => SelectedTeamB);
                TeamBPlayers = DataService.GetPlayersByTeamId(_context, value.TeamId).OrderBy(o => o.OrderNumber).ToList();
                Data.TeamB.Team = value;
            }
        }

        public List<Player> TeamBPlayers
        {
            get => _teamBPlayers;
            set { SetProperty(ref _teamBPlayers, value, () => TeamBPlayers); }
        }

        public List<Player> SelectedTeamAPlayers
        {
            get => _selectedTeamAPlayers;
            set
            {
                SetProperty(ref _selectedTeamAPlayers, value, () => SelectedTeamAPlayers);
                UpdatePlayers(Data.TeamA, value);
            }
        }

        private void UpdatePlayers(TeamMatch team, List<Player> value)
        {
            var players = new List<Player>();
            players.Clear();
            foreach (var player in value)
            {
                players.Add(player);
            }

            team.Players = players;
        }

        public List<Player> SelectedTeamBPlayers
        {
            get => _selectedTeamBPlayers;
            set
            {
                SetProperty(ref _selectedTeamBPlayers, value, () => SelectedTeamBPlayers);
                UpdatePlayers(Data.TeamB, value);
            }
        }

        public List<Team> Teams => DataService.GetTeams(_context);


    }
}