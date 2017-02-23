using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebStore.DAL;

namespace WebStore.DAL
{
    public class ProductsViewModel
    {
        public int ID { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }
        public int CategoryID { get; set; }
        public List<SelectListItem> categories { get; set; }

    }
}