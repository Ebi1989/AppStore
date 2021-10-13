using Asp06Store.Framwork.Infra;

namespace Asp06Store.Core.Domain.Models.Products
{
    public interface IProductRepository
    {
        PagedData<Product> GetAll(string category,int pageNumber, int pageSize);
        Product GetById(int id);
        List<string> GetAllCategories();
    }
}
