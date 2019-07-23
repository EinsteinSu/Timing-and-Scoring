using System.Collections.Generic;
using System.Linq;
using DevExpress.Mvvm;
using WaterPolo.Simple.DataAccess;
using WaterPolo.Simple.DataCenter.New.Commons;

namespace WaterPolo.Simple.DataCenter.New.ViewModels
{
    public class ScheduleTeamEditViewModel : ViewModelBase
    {
        private readonly CapColor _color;
        private readonly WaterPoloDataContext _context;
        private readonly Schedule _schedule;
        private List<Player> _selectedPlayers;
        private Team _selectedTeam;
        private int _captainPlayerId;

        public ScheduleTeamEditViewModel()
        {
        }

        public ScheduleTeamEditViewModel(WaterPoloDataContext context, Schedule schedule, CapColor color)
        {
            _schedule = schedule;
            _color = color;
            _context = context;
            Teams = DataService.GetTeams(_context);
            if (TeamMatch.TeamId > 0)
            {
                SelectedTeam = TeamMatch.Team;
                _selectedPlayers = TeamMatch.Players;
                if (TeamMatch.CaptainPlayerId.HasValue)
                    CaptainPlayerId = TeamMatch.CaptainPlayerId.Value;
                RaisePropertiesChanged(new string[] { "SelectedTeam", "SelectedPlayers" });
            }
        }

        public List<Team> Teams { get; set; }

        public Team SelectedTeam
        {
            get => _selectedTeam;
            set
            {
                SetProperty(ref _selectedTeam, value, () => SelectedTeam);
                Players = DataService.GetPlayersByTeamId(_context, value.TeamId).OrderBy(o => o.OrderNumber).ToList();
                RaisePropertiesChanged("Players");
                if (_schedule != null)
                    TeamMatch.Team = value;
            }
        }

        public List<Player> Players { get; set; }

        public List<Player> SelectedPlayers
        {
            get => _selectedPlayers;
            set
            {
                SetProperty(ref _selectedPlayers, value, () => SelectedPlayers);
                if (_schedule != null)
                    UpdatePlayers(TeamMatch, value);
            }
        }

        public int CaptainPlayerId
        {
            get => _captainPlayerId;
            set
            {
                SetProperty(ref _captainPlayerId, value, () => CaptainPlayerId);
                TeamMatch.CaptainPlayerId = value;
            }
        }

        protected TeamMatch TeamMatch => _color == CapColor.White ? _schedule.TeamA : _schedule.TeamB;

        protected void OnSelectedPlayersChanged()
        {
            UpdatePlayers(TeamMatch, SelectedPlayers);
        }

        private void UpdatePlayers(TeamMatch team, List<Player> value)
        {
            var players = new List<Player>();
            players.Clear();
            foreach (var player in value) players.Add(player);

            team.Players = players;
        }
    }
}