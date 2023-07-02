using HealthyFoodWebApplication.Models;
using HealthyFoodWebApplication.Repositories.ProductRepository;
using HealthyFoodWebApplication.Repositories.ShoppingBag;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HealthyFoodWebApplication.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;
        private readonly IShoppingBagRepository _shoppingBag;

        public ProductController(IProductRepository repository, IShoppingBagRepository shoppingBag)
        {
            _repository = repository;
            _shoppingBag = shoppingBag;
        }
        public IActionResult GetProductView(int id)
        {
            List<Product> AllProductsModel = _repository.GetAll();

            return View("Product", AllProductsModel);
        }
        //[HttpPost]
        public IActionResult AddToCart(int productId)
         {
            var product= _repository.GetById(productId);
            if (ModelState.IsValid)
            {
                var ProductItem = new ShoppingBagItem
                {
                    ProductName = product.Name,
                    ProductPrice = product.Price,
                    ProductQuantity = product.Quantity,
                    ProductTotalPrice = product.Price.ToString()
                };
                _shoppingBag.Add(ProductItem);
                _shoppingBag.Save();
            }
            return RedirectToAction("GetProductView");
        }
       
    }
    }






