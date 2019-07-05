using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public override void Edit()
        {
        }

        public override object GetItemSource()
        {
            return Context.Teams.ToList();
        }

        public override object NewItem()
        {
            var team = new Team();
            team.DisplayName = "CHN";
            return team;
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
