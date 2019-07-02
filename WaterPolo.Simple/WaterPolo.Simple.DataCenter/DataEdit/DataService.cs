using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.DataEdit
{
    public static class DataService
    {
        public static List<Team> GetTeams(WaterPoloDataContext context)
        {
            return context.Teams.ToList();
        }

        public static List<Player> GetPlayersByTeamId(WaterPoloDataContext context, int teamId)
        {
            return context.Teams.Find(teamId).Players.ToList();
        }
    }
}
