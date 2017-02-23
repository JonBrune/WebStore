using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebStore.DAL
{
    public class DataContext : DbContext
    {
        public DataContext() : base("WebStoreDataLink")
        {
            Database.SetInitializer<DataContext>(new DropCreateDatabaseAlways<DataContext>());
        }
        public DbSet<Products> Products { get; set; }

        public DbSet<Categories> Categories { get; set; }


    }
}