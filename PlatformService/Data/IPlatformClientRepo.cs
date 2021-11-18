using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatformClientRepo
    {
        bool SaveChanges();
        IEnumerable<Platform> GetAll();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform platform);  
    }
}