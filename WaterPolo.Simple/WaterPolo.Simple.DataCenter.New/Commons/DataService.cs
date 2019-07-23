using System.Collections.Generic;
using System.Linq;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.New.Commons
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