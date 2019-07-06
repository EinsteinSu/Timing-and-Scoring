namespace WaterPolo.Simple.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WaterPolo.Simple.DataAccess.WaterPoloDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WaterPolo.Simple.DataAccess.WaterPoloDataContext";
        }

        protected override void Seed(WaterPolo.Simple.DataAccess.WaterPoloDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
