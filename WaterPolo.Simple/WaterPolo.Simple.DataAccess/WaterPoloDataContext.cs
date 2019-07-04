using System.Data.Entity;

namespace WaterPolo.Simple.DataAccess
{
    public class WaterPoloDataContext : DbContext
    {
        public WaterPoloDataContext() : base("WaterPolo")
        {
        }

        public IDbSet<Team> Teams { get; set; }

        public IDbSet<Player> Players { get; set; }
        public IDbSet<Schedule> Schedules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Team>().HasMany(t => t.Players).WithRequired(p => p.Team).WillCascadeOnDelete(false);
        }
    }
}