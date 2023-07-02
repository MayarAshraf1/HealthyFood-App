using Microsoft.AspNetCore.Mvc;

namespace HealthyFoodWebApplication.Controllers
{
    public class TestimonialController : Controller
    {
        public IActionResult GetTestimonialView()
        {
            return PartialView("Testimonial");
        }
    }
}
