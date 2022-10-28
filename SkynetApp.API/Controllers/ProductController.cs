using SkynetApp.API.Service;
using Microsoft.AspNetCore.Mvc;
using SkynetApp.API.Models;

namespace SkynetApp.API.Controllers
{
    [ApiController]
    [Route("api /[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _product;
        public ProductController(IProductService product)
        {
            _product = product;
        }

        [HttpGet("Products")]
        public async Task<IEnumerable<Product>> GetallProducts()
        {
           
           return  await _product.GetAllProducts();
          
        }
        [HttpGet("product")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var res = await _product.GetProduct(id);
            return Ok(res);
        }
    }
}
