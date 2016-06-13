using NotchCityLighting.Core.Models;
using System.Collections.Generic;

namespace NotchCityLighting.Core.Interfaces
{
    public interface ILightRepository
    {
        IEnumerable<Light> Get();
        Light GetByLightId(int id);
        bool CreateLight(Light newLight);
        bool UpdateLight(Light updatedLight);
        bool DeleteLight(Light deletedLight);
    }
}
