using Asp06Store.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp06Store.ShopUI.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductRepository productRepository;
        public CartController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }
        public IActionResult AddToCart(int id, string returnUrl)
        {
            Product product = productRepository.GetById(id);
            if (product != null)
            {
                Cart cart = GetCart();
                cart.AddItem(product, 1);
                SaveCart(cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToActionResult RemoveFromCart(int id, string returnUrl)
        {
            Product product = productRepository.GetById(id);
            if (product != null)
            {
                Cart cart = GetCart();
                cart.RemoveLine(product);
                SaveCart(cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart();
            return cart;
        }
        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetJson("Cart", cart);
        }
    }
}
