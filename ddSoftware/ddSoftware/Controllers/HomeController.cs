using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ddSoftware.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A long history with technology";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Here to Serve";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "DD Software";

            return View();
        }
    }
}