using System.Data.Entity;
using System.Linq;

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

        public bool HasChanged()
        {
            return this.ChangeTracker.Entries().Any(e => e.State == EntityState.Added
                                                         || e.State == EntityState.Modified
                                                         || e.State == EntityState.Deleted);
        }
    }

    public enum DataEditType
    {
        New, Edit, Remove
    }
}