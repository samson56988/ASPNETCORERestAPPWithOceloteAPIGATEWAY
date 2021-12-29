using Microservices.Model;
using System.Collections.Generic;

namespace Microservices.Services
{
    public interface ICategoryService
    {
        List<Category> FindAll();
    }
}
