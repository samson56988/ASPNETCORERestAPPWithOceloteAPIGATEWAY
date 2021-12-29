using Microservices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
      
        private ICategoryService _categoryService;
      
        public CatalogController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [Produces("application/json")]
        [HttpGet("findall")]
        public IActionResult FindAll()
        {
            try
            {
                return Ok(_categoryService.FindAll());
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
