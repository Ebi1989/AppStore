namespace Asp06Store.ShopUI.Models
{
    public interface IProductRepository
    {
        PagedData<Product> GetAll(string category,int pageNumber, int pageSize);
        Product GetById(int id);
        List<string> GetAllCategories();
    }
}
