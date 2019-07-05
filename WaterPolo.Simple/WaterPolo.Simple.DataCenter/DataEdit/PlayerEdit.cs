using System;
using System.Linq;
using DevExpress.Xpf.Grid;
using WaterPolo.Simple.DataAccess;
using WaterPolo.Simple.DataCenter.DataEdit.EditWindow;

namespace WaterPolo.Simple.DataCenter.DataEdit
{
    public class PlayerEdit : DataManagerBase
    {
        public override void Add(object Item)
        {
            var player = ((PlayerEditViewModel)Item).Data;
            Context.Players.Add(player);
            Context.SaveChanges();
        }

        public override void Edit()
        {
            throw new NotImplementedException();
        }

        public override object GetItemSource()
        {
            return Context.Players.ToList();
        }

        public override object NewItem()
        {
            var player = new Player();
            player.DisplayName = "Player";
            return new PlayerEditViewModel(Context, player);
        }

        public override void Delete()
        {
            if (CurrentItem is Player player)
            {
                Context.Players.Remove(player);
                Context.SaveChanges();
            }
        }
    }
}