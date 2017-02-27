using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebStore.DAL;

namespace WebStore.ViewModels
{
    public class ProductsViewModel
    {
        public int ID { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
        public int CategoryID { get; set; }
        public IEnumerable<Categories> categories { get; set; }
        public IEnumerable<Products> products { get; set; }
        public DataContext db { get; set; }
        public int SelectedID { get; set; }
    }
}