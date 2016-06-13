using NotchCityLighting.Core.Models;
using System.Collections.Generic;

namespace NotchCityLighting.Core.Interfaces
{
    public interface ILightPartRepository
    {
        IEnumerable<LightPart> Get();
        LightPart GetByLightPartId(int id);
        IEnumerable<LightPart> GetLightPartsByLightId(int id);
        bool CreateLightPart(LightPart newPart);
        bool UpdateLightPart(LightPart updatedPart);
        bool DeleteLightPart(int id);
    }
}
