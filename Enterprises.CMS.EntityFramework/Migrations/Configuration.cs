namespace Enterprises.CMS.Migrations
{
    using SeedData;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Enterprises.CMS.EntityFramework.CMSDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Enterprises.CMS.EntityFramework.CMSDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            new InitialDataBuilder(context).Build(); // 如果数据初始化不进去，放开此语句
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
