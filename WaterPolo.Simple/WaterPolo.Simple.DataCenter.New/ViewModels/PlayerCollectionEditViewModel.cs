using System.Data.Entity;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using WaterPolo.Simple.DataAccess;
using WaterPolo.Simple.DataCenter.New.ViewModels.Models;

namespace WaterPolo.Simple.DataCenter.New.ViewModels
{
    [POCOViewModel]
    public class PlayerCollectionEditViewModel : EditViewModelBase<Player, PlayerIE>, ISupportParameter
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
                AddItem(player);
            }
        }

        protected override void AddItem(Player item)
        {
            Context.Players.Add(item);
        }

        protected override void RemoveItem()
        {
            Context.Players.Remove(CurrentItem);
        }

        protected override Player ConvertFromImportData(PlayerIE importData)
        {
            return new Player
            {
                Name = importData.Name,
                DisplayName = importData.DisplayName,
                OrderNumber = importData.OrderId,
                DisplayNumber = importData.Number,
                TeamId = _currentTeam.TeamId
            };
        }

        protected override PlayerIE ConvertToExportData(Player data)
        {
            return new PlayerIE
            {
                DisplayName = data.DisplayName,
                Name = data.Name,
                Number = data.DisplayNumber,
                OrderId = data.OrderNumber
            };
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