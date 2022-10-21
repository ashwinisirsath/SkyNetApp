using SkynetApp.API.Service;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet ("Products")]
        public string GetallProducts()
        {
            return _product.GetAllProducts();
    }
}
