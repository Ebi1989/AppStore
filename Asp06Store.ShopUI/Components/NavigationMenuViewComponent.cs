using Asp06Store.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp06Store.ShopUI.Components
{

    public class NavigationMenuViewComponent : ViewComponent
    {
        private readonly IProductRepository productRepository;

        public NavigationMenuViewComponent(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            var catetories = productRepository.GetAllCategories();
            return View(catetories);

        }
    }
}

