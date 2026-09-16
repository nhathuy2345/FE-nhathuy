using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FE_nhathuy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Bt5_lab01()
        {
            return View();
        }
        public ActionResult BT1_lab01()
        {
            return View();
        }
        public ActionResult bt2_la01b()
        {
            return View();
        }
        public ActionResult bt3_lab01a()
        {
            return View();
        }
        public ActionResult BT1_LAP01A()
        {
            return View();
        }

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
    }
}