using CDM.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CDM.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Action = ControllerContext.RouteData.Values["Action"]?.ToString();
            ViewBag.Controller = ControllerContext.RouteData.Values["Controller"]?.ToString();
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.Action = ControllerContext.RouteData.Values["Action"]?.ToString();
            ViewBag.Controller = ControllerContext.RouteData.Values["Controller"]?.ToString();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
