using System.Collections.Generic;
using Website_Shop.Models.Entities;

namespace Website_Shop.Models.ViewModels
{
    public class ProductsViewModel
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
