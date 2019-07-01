using System;
using System.Collections.Generic;
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
    }
}
