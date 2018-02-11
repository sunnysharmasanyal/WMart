using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WMart.Models
{
    public class ShoppingCart
    {
        // Shopping Cart using Extension Methods
        // Extension Methods are a convenent way of adding methods to class that you
        // Dont own  and cannot modify directly 
        public List<Products> Products { get; set; }
    }
}