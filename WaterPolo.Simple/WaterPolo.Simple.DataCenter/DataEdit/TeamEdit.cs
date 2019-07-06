using System.Linq;
using System.Windows;
using Newtonsoft.Json;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.DataEdit
{
    public class TeamEdit : DataManagerBase
    {
        public override void Add(object item)
        {
            Context.Teams.Add((Team)item);
            Context.SaveChanges();
        }

        public override object GetItemSource()
        {
            return Context.Teams.ToList();
        }

        public override object NewItem()
        {
            var team = new Team { DisplayName = "CHN" };
            return team;
        }

        protected override object ConvertDataFromText(string data)
        {
            return JsonConvert.DeserializeObject<Team>(data);
        }

        public override void Copy()
        {
            if (CurrentItem is Team item)
            {
                var team = new Team
                {
                    Name = item.Name,
                    DisplayName = item.DisplayName,
                    Flag = item.Flag
                };
                var data =JsonConvert.SerializeObject(team);
                Clipboard.SetText(data);
            }
        }

        public override void Delete()
        {
            if (CurrentItem is Team team)
            {
                Context.Teams.Remove(team);
                Context.SaveChanges();
            }
        }
    }
}