using Microservices.Model;
using System.Collections.Generic;

namespace Microservices.Services
{
    public class CategoryService : ICategoryService
    {
        public List<Category> FindAll()
        {
            return new List<Category>
            {
                new Category {Id = "c1", Name = "Category 1"},
                new Category {Id = "c2", Name = "Category 2"},
                new Category {Id = "c3", Name = "Category 3"},
                new Category {Id = "c4", Name = "Category 4"},
                new Category {Id = "c5", Name = "Category 5"}
            };
        }
    }
}
