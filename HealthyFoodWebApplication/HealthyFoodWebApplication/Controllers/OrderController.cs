using Microsoft.AspNetCore.Mvc;

namespace HealthyFoodWebApplication.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult GetOrderView()
        {
            return View("Order");
        }
    }
}
