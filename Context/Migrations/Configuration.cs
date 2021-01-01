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
            SeedCategories(context);
            SeedItemMasters(context);
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
        private void SeedCategories(CommonContext context)
        {
            context.Categories.AddOrUpdate(x => x.CatCode, new Model.Category
            {
                ShortDescription = "SMPL",
                LongDescription = "SAMPLE",
                CatCode="12345678900000"
            });
            context.Categories.AddOrUpdate(x => x.CatCode, new Model.Category
            {
                ShortDescription = "DRNK",
                LongDescription = "DRINKS",
                CatCode = "12345678900001"
            });
        }
        private void SeedItemMasters(CommonContext context)
        {
            context.ItemMasters.AddOrUpdate(x => x.ItemCode, new Model.ItemMaster
            {
                ShortDescription = "SMPL1",
                LongDescription = "SAMPLE 1",
                BarCode = "1728392047162",
                ItemCode = "SMPL1",
                CategoryId = 1 //category
            });
            context.ItemMasters.AddOrUpdate(x => x.ItemCode, new Model.ItemMaster
            {
                ShortDescription = "SMPL2",
                LongDescription = "SAMPLE 2",
                BarCode = "1728392057161",
                ItemCode = "SMPL2",
                CategoryId = 1 //category
            });
        }
    }
}
