using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DylanTaylorArt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Gallery()
        {
            ViewBag.Message = "Your Gallery page.";

            return View();
        }

        public ActionResult Collections()
        {
            ViewBag.Message = "Your Collections page.";

            return View();
        }

        public ActionResult Shows()
        {
            ViewBag.Message = "Your on show page.";

            return View();
        }

    }
}