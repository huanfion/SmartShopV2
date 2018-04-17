using System.Data.Entity.Migrations;

namespace SmartShop.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SmartShop.EntityFramework.SmartShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SmartShop";
        }

        protected override void Seed(SmartShop.EntityFramework.SmartShopDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
