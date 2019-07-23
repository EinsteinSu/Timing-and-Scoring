using System.Data.Entity;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.New.ViewModels
{
    [POCOViewModel]
    public class PlayerCollectionEditViewModel : EditViewModelBase<Player>, ISupportParameter
    {
        private object _parameter;
        private Team _currentTeam;

        public PlayerCollectionEditViewModel()
        {

        }

        public override void Add()
        {
            if (_currentTeam != null)
            {
                var player = new Player { TeamId = _currentTeam.TeamId };
                player.DisplayName = player.Name = "New Player";
                Context.Players.Add(player);
            }
        }

        protected override void RemoveItem()
        {
            Context.Players.Remove(CurrentItem);
        }

        protected override void RefreshItems()
        {
            var id = _currentTeam == null ? 0 : _currentTeam.TeamId;
            Context.Players.Where(w => w.TeamId == id).Load();
            Items = Context.Players.Local;
        }

        public object Parameter
        {
            get => _parameter;
            set
            {
                _parameter = value;
                _currentTeam = (Team)value;
                Refresh();
            }
        }

    }
}