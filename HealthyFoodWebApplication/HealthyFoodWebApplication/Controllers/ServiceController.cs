using Microsoft.AspNetCore.Mvc;

namespace HealthyFoodWebApplication.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult GetServiceView()
        {
            return PartialView("Service");
        }
    }
}
