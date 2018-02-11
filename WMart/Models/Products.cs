using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WMart.Models
{
    public class Products
    { 
        // objects 
        public int productID { get; set; }
        public string productName { get; set; }
        public string description { get; set; }
        public string price { get; set; }
        public string catagory { get; set; }
    }
}