using Asp06Store.Core.Domain.Models.Products;
using Asp06Store.Framwork.Infra;
using System.Collections.Generic;
using System.Linq;

namespace Asp06Store.Core.Domain.Models
{
    public class EfProductRepository : IProductRepository
    {
        private readonly StoreDbContext storeDbContext;

        public EfProductRepository(StoreDbContext storeDbContext)
        {
            this.storeDbContext = storeDbContext;
        }
        public PagedData<Product> GetAll(string category,int pageNumber, int pageSize)
        {
            var result = new PagedData<Product>
            {
                PageInfo = new PageInfo
                {
                    PageSize = pageSize,
                    PageNumber = pageNumber
                }
            };

            result.Data = storeDbContext.Products.Where(c=>string.IsNullOrEmpty(category) || c.Category == category).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            result.PageInfo.TotalCount = storeDbContext.Products.Where(c => string.IsNullOrEmpty(category) || c.Category == category).Count();
            return result;
        }

        public List<string> GetAllCategories()
        {
            return storeDbContext.Products.Select(c=>c.Category).Distinct().ToList();
        }

        public Product GetById(int id)
        {
            return storeDbContext.Products.FirstOrDefault(c => c.Id == id);
        }

    }
}
