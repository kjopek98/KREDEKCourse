using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KrzysztofJopekLab6ZadanieDomowe.Models;

namespace KrzysztofJopekLab6ZadanieDomowe.Controllers
{
    public class HomeController : Controller
    {
        List<BallerViewModel> ballers;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            ballers = new List<BallerViewModel>();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllBallers()
        {
            return View(ballers);
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
