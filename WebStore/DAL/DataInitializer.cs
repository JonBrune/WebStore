using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStore.DAL
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var products = new List<Products>
            {
                new Products { ID = 1, name = "test product 1", price = 2.50, description = "ding dong deng another product", date = new DateTime(2017, 10, 10), CategoriesID = 1 }
               
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