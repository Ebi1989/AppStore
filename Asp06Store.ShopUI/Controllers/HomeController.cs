using Asp06Store.Core.Domain.Models.Products;
using Asp06Store.Core.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Asp06Store.ShopUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;
        private int pageSize = 2;
        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index(string category,int pageNumber = 1)
        {
            var model = new ProductsListViewModel
            {
                ProductPagedData = productRepository.GetAll(category,pageNumber, pageSize),
                CurrentCategory = category
            };
            return View(model);
        }
    }
}
