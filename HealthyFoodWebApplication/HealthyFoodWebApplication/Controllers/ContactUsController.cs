using Microsoft.AspNetCore.Mvc;

namespace HealthyFoodWebApplication.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult GetContactUsView()
        {
            return View("ContactUs");
        }

        public IActionResult GetMessageView()
        {
            return View("Message");
        }
    }
}
