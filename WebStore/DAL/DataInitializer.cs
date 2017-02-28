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
                new Categories { name = "Automative & Industrial" }
            };
            categories.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();

            var products = new List<Products>
            {
                new Products {name = "test product 1", price = 2.50, description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                    longDescription = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium", date = new DateTime(2017, 10, 10), Stock = 10, CategoriesID = 1 },
                new Products { name = "test product 2", price = 4.20, description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                    longDescription = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",  date = new DateTime(2017, 9, 9), Stock = 10, CategoriesID = 2 },
                new Products { name = "test product 3", price = 2.50, description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                    longDescription = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",  date = new DateTime(2017, 10, 10), Stock = 10, CategoriesID = 4  },
                new Products {  name = "test product 4", price = 4.20, description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                    longDescription = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",  date = new DateTime(2017, 9, 9), Stock = 10, CategoriesID = 5  },
                new Products { name = "test product 5", price = 2.50, description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                    longDescription = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",  date = new DateTime(2017, 10, 10), Stock = 10, CategoriesID = 2  },
                new Products { name = "test product 6", price = 4.20, description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                    longDescription = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",  date = new DateTime(2017, 9, 9), Stock = 10, CategoriesID = 3  },
                new Products { name = "test product 7", price = 4.20, description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                    longDescription = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",  date = new DateTime(2017, 9, 9), Stock = 10, CategoriesID = 2 },
                new Products {  name = "test product 8", price = 2.50, description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                    longDescription = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",  date = new DateTime(2017, 10, 10), Stock = 10, CategoriesID = 1  },
                new Products { name = "test product 9", price = 4.20, description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit",
                    longDescription = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",  date = new DateTime(2017, 9, 9), Stock = 10, CategoriesID = 1  }
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

        }
    }
}