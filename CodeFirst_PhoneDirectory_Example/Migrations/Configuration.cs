namespace CodeFirst_PhoneDirectory_Example.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst_PhoneDirectory_Example.Infrastructure.Context.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; // her defasında uzun uzun uğraşmamk ve direkt update-migration dediğimizde database de değişiklik olsun istedik 
        }

        protected override void Seed(CodeFirst_PhoneDirectory_Example.Infrastructure.Context.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
