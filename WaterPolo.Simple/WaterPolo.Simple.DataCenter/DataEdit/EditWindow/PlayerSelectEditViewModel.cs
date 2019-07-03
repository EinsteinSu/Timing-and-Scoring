using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using DevExpress.Mvvm;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.DataEdit.EditWindow
{
    public class PlayerSelectEditViewModel : ViewModelBase, IDialogWindow
    {
        private readonly TeamMatch _teamMatch;
        private readonly WaterPoloDataContext _context;
        private readonly PlayerSelect _playerSelect;
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

        private int _selectedTeamId;
        private List<Player> _players;
        private List<Player> _selectedPlayers;
        public string Title => "Player Selection";
        public FrameworkElement Content => _playerSelect;

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

    public class PlayerConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var items = new List<object>();
            if (value is IList<Player> players)
            {
                foreach (Player item in players)
                {
                    items.Add(item);
                }
            }
            return items;


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var results = new List<Player>();
            if (value is IList<object> items)
            {
                foreach (object item in items)
                {
                    results.Add((Player)item);
                }
            }

            return results;

        }
    }
}