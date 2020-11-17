using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NET_JKTVR19_Praktika1.Models;

namespace NET_JKTVR19_Praktika1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string name = "World";
            ViewBag.Hello = "Hello, " + name;
            int hour = DateTime.Now.Hour;

            ViewBag.Greeting = hour < 12 ? "Tere hommikust" : "Tere päevast";

            return View();
        }
        [HttpGet]
        public ViewResult RegisterForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RegisterForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
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
    }
}