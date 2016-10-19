using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyLogger2.Models;

namespace MyLogger2.Controllers
{
    public class HomeController : Controller
    {
        private ILogger _logger;
        public  HomeController(ILogger logger)
        {
            _logger = logger;
        }
        public ActionResult Index()
        {
            _logger.LogInfoEvent("Index hit");
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