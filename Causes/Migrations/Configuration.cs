namespace Causes.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Causes.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Causes.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Causes.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.CauseTypes.AddOrUpdate(x => x.Id,
                new CauseType() { Id = 1, Type = "Racism" },
                new CauseType() { Id = 2, Type = "Bullying" },

                new CauseType() { Id = 3, Type = "Nepotism" },
                new CauseType() { Id = 4, Type = "Sexual Harassment" },
                new CauseType() { Id = 5, Type = "Discrimination" },
                new CauseType() { Id = 6, Type = "Other" });



        }
    }
}
