using Lab04MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab04MVC.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Test2()
        {
            
            DateTime date = DateTime.Now;
            ViewBag.Greeting = "Good Afternoon ";
            ViewBag.Greeting += "The time is " + date.ToShortTimeString();
            ViewBag.Greeting += ", and the date is " + date.ToLongDateString();
            ViewBag.Greeting += ", which is day " + date.DayOfYear;

      
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Test()
        {
            Person p = new Person { FirstName = "Joe", LastName = "Wallice", BirthDate = new DateTime(1980, 1, 10) };
            return View(p);
        }

        [HttpPost]
        public ActionResult Test(Person newPerson)
        {
            bool ok = ModelState.IsValid;
            return View(newPerson);
        }
    }
}