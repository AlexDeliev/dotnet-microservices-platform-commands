using System.Collections.Generic;
using Platform.Service.Models;

namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        bool SaveChanges();

        IEnumerable<PlatformModel> GetAllPlatforms();
        PlatformModel GetPlatformById(int id);
        void CreatePlatform(PlatformModel plat);
    }
}