
using Asp06Store.Core.Domain.Models;

namespace Asp06Store.Core.Domain.ViewModels

{

    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}

