using SkynetApp.API.Models;

namespace SkynetApp.API.Service
{
    public interface IAccountService
    {
        public Task<IEnumerable<AppUser>> RegisterAsync(AppUser appUser, string password);

    }
}
