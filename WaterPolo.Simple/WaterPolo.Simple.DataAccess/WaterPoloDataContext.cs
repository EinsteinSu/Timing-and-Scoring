using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterPolo.Simple.DataAccess
{
    public class WaterPoloDataContext : DbContext
    {
        public WaterPoloDataContext() : base("WaterPolo")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Team>().HasMany(t => t.Players).WithRequired(p => p.Team).WillCascadeOnDelete(false);
        }

        public IDbSet<Team> Teams { get; set; }

        public IDbSet<Player> Players { get; set; }
        public IDbSet<Schedule> Schedules { get; set; }
    }
}
