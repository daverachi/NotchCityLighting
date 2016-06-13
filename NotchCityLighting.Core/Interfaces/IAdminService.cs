using NotchCityLighting.Core.Models;

namespace NotchCityLighting.Core.Interfaces
{
    public interface IAdminService
    {
        bool CreateLight(Light light);
        bool UpdateLight(Light light);
        bool DeleteLight(int id);
    }
}
