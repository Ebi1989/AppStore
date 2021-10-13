
using Asp06Store.Core.Domain.Models.Products;
using Asp06Store.Framwork.Infra;

namespace Asp06Store.Core.Domain.ViewModels
{
    public class ProductsListViewModel
    {
        public PagedData<Product> ProductPagedData  { get; set; }
        public string CurrentCategory { get; set; }
    }
}
