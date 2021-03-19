using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tre_lager.Controllers
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
            ViewBag.TigerNames = 8;

            ViewData["Title"] = "About from viewData";
            ViewBag.Title = "About from controller";

            ViewData["TigerAge"] = 9;
            ViewData["TigerEyeColors"] = new List<string> { 
                "blue",
                "green"
            };

            TempData["info"] = "Temp data from Index method in Home controller";

            return View();
        }

        public ActionResult Contact()
        {
            var info = "";
            if (TempData.ContainsKey("info"))
                info = TempData["info"].ToString();

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}