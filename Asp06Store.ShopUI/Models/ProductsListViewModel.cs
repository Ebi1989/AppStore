namespace Asp06Store.ShopUI.Models
{
    public class ProductsListViewModel
    {
        public PagedData<Product> ProductPagedData  { get; set; }
        public string CurrentCategory { get; set; }
    }
}
