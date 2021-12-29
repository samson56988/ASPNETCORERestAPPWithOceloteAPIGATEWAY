using ProductService.Models;
using System.Collections.Generic;

namespace ProductService.Services
{
    public interface IProductService
    {
        List<Product> FindAll();
    }
}
