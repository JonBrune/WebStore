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


            var categories = new List<Categories>
            {
                new Categories { name = "Books & Audible" },
                new Categories { name = "Movies, Music & Games" },
                new Categories { name = "Electronics & Computers" },
                new Categories { name = "Home, Garden & Tools" },
                new Categories { name = "Beauty, Health & Grocery" },
                new Categories { name = "Toys, Kids & Baby" },
                new Categories { name = "Clothing, Shoes & Jewelry" },
                new Categories { name = "Sport & Outdoors" },
                new Categories { name = "Automative & Industrial" },
                new Categories { name = "All Categories" }
            };
            categories.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();

            var products = new List<Products>
            {
                new Products {name = "test product 1", price = 2.50, description = "ding dong deng another product", date = new DateTime(2017, 10, 10), CategoriesID = 1 },
                new Products { name = "test product 2", price = 4.20, description = "blablabla product blabla", date = new DateTime(2017, 9, 9), CategoriesID = 1 },
                new Products { name = "test product 3", price = 2.50, description = "ding dong deng another product", date = new DateTime(2017, 10, 10),CategoriesID = 1  },
                new Products {  name = "test product 4", price = 4.20, description = "blablabla product blabla", date = new DateTime(2017, 9, 9),CategoriesID = 1  },
                new Products { name = "test product 5", price = 2.50, description = "ding dong deng another product", date = new DateTime(2017, 10, 10),CategoriesID = 1  },
                new Products { name = "test product 6", price = 4.20, description = "blablabla product blabla", date = new DateTime(2017, 9, 9),CategoriesID = 1  },
                new Products { name = "test product 7", price = 4.20, description = "blablabla product blabla", date = new DateTime(2017, 9, 9) ,CategoriesID = 1 },
                new Products {  name = "test product 8", price = 2.50, description = "ding dong deng another product", date = new DateTime(2017, 10, 10),CategoriesID = 1  },
                new Products { name = "test product 9", price = 4.20, description = "blablabla product blabla", date = new DateTime(2017, 9, 9),CategoriesID = 1  }
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

        }
    }
}