using HealthyFoodWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HealthyFoodWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult GetHomeView()
        {
            return View("Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}