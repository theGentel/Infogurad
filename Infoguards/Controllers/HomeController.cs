using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Infoguards.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
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

        public ActionResult HTTP()
        {
            ViewBag.Message = "Your HTTP page.";
            return View();
        }

        public ActionResult HTTPS()
        {
            ViewBag.Message = "Your HTTPS page.";

            return View();
        }

        public ActionResult NetMVC()
        {
            ViewBag.Message = "Your NetMVC page.";

            return View();
        }

        public ActionResult NetCore()
        {
            ViewBag.Message = "Your NetCore page.";

            return View();
        }
    }
}