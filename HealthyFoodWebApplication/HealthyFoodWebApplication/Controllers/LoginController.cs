using Microsoft.AspNetCore.Mvc;

namespace HealthyFoodWebApplication.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult GetLoginView()
        {
            return View("Login");
        }
    }
}
