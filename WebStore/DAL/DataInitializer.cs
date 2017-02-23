using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStore.DAL
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var products = new List<Products>
            {
                new Products { ID = 1, name = "test product 1", price = 2.50, date = new DateTime(2017, 10, 10) },
                new Products { ID = 2, name = "test product 2", price = 4.20, date = new DateTime(2017, 9, 9) }
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            var categories = new List<Categories>
            {
                new Categories { ID = 1, name = "FirstCategory" },
                new Categories { ID = 2, name = "SecondCategory" }
            };
            categories.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();
        }
    }
}