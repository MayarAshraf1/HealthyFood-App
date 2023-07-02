using Microsoft.AspNetCore.Mvc;

namespace HealthyFoodWebApplication.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult GetErrorView()
        {
            return View("Error");
        }
    }
}
