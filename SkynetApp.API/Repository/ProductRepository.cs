using SkynetApp.API.Service
namespace SkynetApp.API.Repository
{
    public class ProductRepository : IProductService
    {
        public string GetAllProducts()
        {
            return "Delever all the Products";
        }
    }
}
