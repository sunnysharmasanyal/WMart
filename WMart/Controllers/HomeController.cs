using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WMart.Models;
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
        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RsvpForm(GuestResponse Employee)
        {
            return View("Thanks",Employee);
        }

    }
}