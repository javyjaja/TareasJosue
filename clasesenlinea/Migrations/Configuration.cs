namespace clasesenlinea.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<clasesenlinea.Models.context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "clasesenlinea.Models.context";
        }

        protected override void Seed(clasesenlinea.Models.context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
