using Cilibia_Malina_Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cilibia_Malina_Lab1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Index()
        {
            return "bun venit!";
        }

        public string salut()
        {
            return "buna ziua";
        }

        public string nume(string nume, int varsta)
        {
            return "Numele studentului este " + nume + " iar varsta este " + varsta;
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
