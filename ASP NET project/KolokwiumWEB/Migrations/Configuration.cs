namespace KolokwiumWEB.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KolokwiumWEB.Models.PeopleDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(KolokwiumWEB.Models.PeopleDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Rabats.AddOrUpdate(m => m.Name, new Models.Rabat { Name = "20%" },
                new Models.Rabat { Name = "50%" },
                new Models.Rabat { Name = "75%" });
        }
    }
}
