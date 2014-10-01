using AngularMVC.Model;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace SimpleTaskSystem.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AngularMVC.EntityFramework.AngularMVCDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AngularMVC.EntityFramework.AngularMVCDbContext context)
        {
            context.Tags.AddOrUpdate(
                p => p.Name,
                new Tag { Name = "Web" },
                new Tag { Name = "Books" },
                new Tag { Name = "ECommerce" },
                new Tag { Name = "Interesting" }
                );
        }
    }
}
