using ProductService.Models;
using System.Collections.Generic;

namespace ProductService.Services
{
    public class ProductServices : IProductService
    {
        public List<Product> FindAll()
        {
            return new List<Product>
            {
                new Product {Id = "p1", Name = "Product 1", Price = 11.3},
                new Product {Id = "p1", Name = "Product 1", Price = 61.4},
                new Product {Id = "p1", Name = "Product 1", Price = 41.5},
                new Product {Id = "p1", Name = "Product 1", Price = 12.5},
                new Product {Id = "p1", Name = "Product 1", Price = 13.3},
            };
        }
    }
}
