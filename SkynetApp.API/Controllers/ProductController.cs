using Microsoft.AspNetCore.Mvc;

namespace SkynetApp.API.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet ("Products")]
        public string GetallProducts()
        {
            return "Delever all Products";
        }
    }
}
