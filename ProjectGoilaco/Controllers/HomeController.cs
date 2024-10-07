using Microsoft.AspNetCore.Mvc;
using ProjectGoilaco.Models;
using System.Diagnostics;

namespace ProjectGoilaco.Controllers
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
            return View();
        }

        public IActionResult Page3()
        {
            return View();
        }

        public IActionResult Page5()
        {
            return View();
        }

        public IActionResult Page6()
        {
            return View();
        }

        public IActionResult Page7()
        {
            return View();
        }

        public IActionResult Page8()
        {
            return View();
        }

        public IActionResult Page9()
        {
            return View();
        }

        public IActionResult Page10()
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
