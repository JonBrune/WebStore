using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebStore.DAL
    
{
    public class Products
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Product Price")]
        public double price { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string description { get; set; }

        [Display(Name = "Long Description")]
        public string longDescription { get; set; }

        [Display(Name ="Release date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime date { get; set; }

        [Display(Name = "In stock")]
        [Required]
        public int Stock { get; set; }
        
        [Display(Name = "Category ID")]

        public int CategoriesID { get; set; }

        public virtual Categories Categories { get; set; }
   
    }
}