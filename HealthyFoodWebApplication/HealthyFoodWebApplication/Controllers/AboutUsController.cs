using Microsoft.AspNetCore.Mvc;

namespace HealthyFoodWebApplication.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult GetAboutUsView()
        {
            return View("AboutUs");
        }
    }
}
