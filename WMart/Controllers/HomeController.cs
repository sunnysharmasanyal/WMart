using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WMart.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning Sir" : "Good Afternoon Sir";
            return View();
        }
        //Creating new ActionResult for URL 
        public ActionResult RsvpForm()
        {
            return View();
        }

    }
}