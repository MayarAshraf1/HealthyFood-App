using Microsoft.AspNetCore.Mvc;

namespace HealthyFoodWebApplication.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult GetArticleView()
        {
            return View("Article");
        }
    }
}
