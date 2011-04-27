using System;
using System.Linq;
using System.Web.Mvc;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductRepository _productRepository;

        // If you are using Dependency Injection, you can delete the following constructor
        public ShopController() : this(new ProductRepository())
        {
        }

        public ShopController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ViewResult Index()
        {
            return View(_productRepository.All);
        }

        [HttpPost] 
        public ActionResult AddToCart(int id)
        {
            var shoppingCart = ShoppingCart.Current;
            var product = _productRepository.Find(id);
            shoppingCart.AddProduct(product);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult ClearCart()
        {
            ShoppingCart.Current.ClearCart();
            return RedirectToAction("Index");
        }



    }
}
