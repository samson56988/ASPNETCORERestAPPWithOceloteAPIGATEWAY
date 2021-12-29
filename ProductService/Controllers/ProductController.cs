using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductService.Services;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Produces("application/json")]
        [HttpGet("findall")]
        public IActionResult FindAll()
        {
            try
            {
                return Ok(_productService.FindAll());
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
