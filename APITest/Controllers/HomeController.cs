using APITest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APITest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            WeatherModel model = new WeatherModel();
            WeatherResultModel weatherResult = WeatherModel.LoadWeatherInfo();
            return View("Index", weatherResult);
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