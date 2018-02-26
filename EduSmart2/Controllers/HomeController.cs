using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EduSmart2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Main()
        {
            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Title = "Login Page";

            return View();
        }
    }
}
