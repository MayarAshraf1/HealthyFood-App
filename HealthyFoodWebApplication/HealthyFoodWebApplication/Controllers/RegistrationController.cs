using Microsoft.AspNetCore.Mvc;

namespace HealthyFoodWebApplication.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult GetRegistrationView()
        {
            return View("Register");
        }
    }
}
