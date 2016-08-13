using System.Data.Entity.Migrations;

namespace MickeyAbpTest.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MickeyAbpTest.EntityFramework.MickeyAbpTestDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MickeyAbpTest";
        }

        protected override void Seed(MickeyAbpTest.EntityFramework.MickeyAbpTestDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
