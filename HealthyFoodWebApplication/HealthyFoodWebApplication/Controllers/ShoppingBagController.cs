using HealthyFoodWebApplication.Models;
using HealthyFoodWebApplication.Repositories.ProductRepository;
using HealthyFoodWebApplication.Repositories.ShoppingBag;
using HealthyFoodWebApplication.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthyFoodWebApplication.Controllers
{
    public class ShoppingBagController : Controller
    {
        private readonly IShoppingBagRepository _bagRepository;
        private readonly IProductRepository _repository;

        public ShoppingBagController(IShoppingBagRepository bagRepository, IProductRepository repository)
        {
            _bagRepository = bagRepository;
            _repository = repository;
        }
        public IActionResult GetShoppingBagView()
        {
            if (ModelState.IsValid)
            {
                List<ShoppingBagItem> items = _bagRepository.GetAll();
                return View(items);
            }
            return View("ShoppingBag");
        }
        public IActionResult DeleteProduct(int id)
        {
            _bagRepository.Delete(id);
            _bagRepository.Save();
            return RedirectToAction("GetShoppingBagView");
        }








    }


}

