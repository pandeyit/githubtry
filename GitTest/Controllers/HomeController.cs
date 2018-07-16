using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();

        }

        public ActionResult About()
        {

            ViewBag.Message = "Feature branch for labelling kiosk";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}