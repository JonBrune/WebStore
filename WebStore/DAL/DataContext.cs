using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure;

namespace WebStore.DAL
{
    public class DataContext : DbContext
    {
        public DataContext() : base("WebStore")
        {
            Database.SetInitializer<DataContext>(new DropCreateDatabaseAlways<DataContext>());
        }
        public DbSet<Products> Products { get; set; }

        public DbSet<Categories> Categories { get; set; }

        //protected override void OnModelCreating(DbModel modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove <PluralizingTableNameConvention>();
        //}
    }
}