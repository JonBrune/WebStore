﻿using System;

namespace WebStore.DAL
    
{
    public class Products
    {
        public int ID { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string description { get; set; } 
        public DateTime date { get; set; }
        public int CategoriesID { get; set; }
        public virtual Categories Categories { get; set; }
        public Products()
        {

        }
        
    }
}