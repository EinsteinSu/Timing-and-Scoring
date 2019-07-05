using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.DataEdit.EditWindow
{
    public class PlayerEditViewModel : ViewModelBase
    {
        private readonly WaterPoloDataContext _context;
        private Player _data;

        public PlayerEditViewModel(WaterPoloDataContext context, Player data)
        {
            _context = context;
            Data = data;
        }

        public Player Data
        {
            get => _data;
            set { SetProperty(ref _data, value, () => Data); }
        }

        public List<Team> Teams => DataService.GetTeams(_context);
    }
}
