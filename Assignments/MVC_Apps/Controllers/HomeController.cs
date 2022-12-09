using Microsoft.AspNetCore.Mvc;
using MVC_Apps.Models;
using System.Diagnostics;

namespace MVC_Apps.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //for every this method we have a cshtml in views
        public IActionResult Index()
        {
            //the view without parameter will return the view tha matches with the action method name
            //in the sub folder of view folder that matches with the controller name
            //View->Home->Index.cshtml
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}