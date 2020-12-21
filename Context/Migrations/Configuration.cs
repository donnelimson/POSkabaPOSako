using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.Migrations
{
    internal sealed class Configuration:DbMigrationsConfiguration<CommonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        protected override void Seed(CommonContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            SeedAppusers(context);
        }
        private void SeedAppusers(CommonContext context)
        {
            context.Appusers.AddOrUpdate(x => x.Username, new Model.Appuser
            {
                FirstName="Admin",
                LastName ="Admin",
                Password="asdf1234",
                Username="admin"
            });
            context.SaveChanges();
        }
    }
}
