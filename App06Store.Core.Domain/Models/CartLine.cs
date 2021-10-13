using Asp06Store.Core.Domain.Models.Products;

namespace Asp06Store.Core.Domain.Models
{
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}

