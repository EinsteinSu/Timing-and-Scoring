using System;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using Newtonsoft.Json;
using WaterPolo.Simple.DataAccess;
using WaterPolo.Simple.DataCenter.DataEdit.EditWindow;

namespace WaterPolo.Simple.DataCenter.DataEdit
{
    public class PlayerEdit : DataManagerBase
    {
        public override void Add(object item)
        {
            if (item is Player player)
            {
                player.PlayerId = 0;
                Context.Players.Add(player);
            }

            if (item is PlayerEditViewModel pvm)
            {
                Context.Players.Add(pvm.Data);
            }

            Context.SaveChanges();
        }

        public override void Edit(object item)
        {
            if (item is PlayerEditViewModel pvm)
            {
                base.Edit(pvm.Data);
            }
        }

        public override object GetItemSource()
        {
            return Context.Players.Include(i => i.Team).ToList();
        }

        public override object NewItem()
        {
            var player = new Player { DisplayName = "Player" };
            return new PlayerEditViewModel(Context, player);
        }

        protected override object ConvertDataFromText(string data)
        {
            return JsonConvert.DeserializeObject<Player>(data);
        }

        public override void Delete()
        {
            if (CurrentItem is Player player)
            {
                Context.Players.Remove(player);
                Context.SaveChanges();
            }
        }

        public override void Copy()
        {
            if (CurrentItem is Player item)
            {
                var player = new Player
                {
                    Name = item.Name,
                    DisplayName = item.DisplayName,
                    TeamId = item.TeamId,
                    OrderNumber = item.OrderNumber
                };

                var data = JsonConvert.SerializeObject(player);
                Clipboard.SetText(data);
            }
        }
    }
}