using Microsoft.AspNetCore.Mvc;

namespace HealthyFoodWebApplication.Controllers
{
    public class BlogGridController : Controller
    {
        public IActionResult GetBlogGridView()
        {
            return View("BlogGrid");
        }
    }
}
