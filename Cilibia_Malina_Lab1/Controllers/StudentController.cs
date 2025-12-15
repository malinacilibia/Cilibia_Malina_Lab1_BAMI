using Cilibia_Malina_Lab1.Models;
using Microsoft.AspNetCore.Mvc;


namespace Cilibia_Malina_Lab1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Info()
        {
            var student = new Student { Name = "Ana", Age = 21 };
            ViewBag.Message = "Mesaj din Controller";
            ViewData["Time"] = DateTime.Now;
            return View(student);
        }

      
    }
}
