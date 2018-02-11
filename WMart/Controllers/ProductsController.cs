using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WMart.Models;
namespace WMart.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        //objects and collections initializers
        public ActionResult Index()
        {

            return View();
        }
       
        //Conecptual Method
        public ViewResult productChange()
        {
            // creating product object here
            //objects initializers
            Products prd = new Products{ productID = 1,
                productName = "Mango",
                catagory = "Fruits",
                description = "American Mangoes",
                price = "200"
            };
           
          
            return View("Result",(object)string.Format("productName:{0}",prd.productName));
        }
    }
}