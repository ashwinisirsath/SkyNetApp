using SkynetApp.API.Models;
namespace SkynetApp.API.Service
{
    public interface IProductService
    {
        public Task<IEnumerable<Product>> GetAllProducts();
        public Task<IEnumerable<Product>> GetProduct(int id);
    }
}
