using NotchCityLighting.Core.Models;
using System.Collections.Generic;

namespace NotchCityLighting.Core.Interfaces
{
    public interface ILookupService
    {
        IEnumerable<Light> GetLights();
        Light GetLightById(int id);
        IEnumerable<Part> GetParts();
        Part GetPartById(int id);
        IEnumerable<LightPart> GetLightPartsByLightId(int id);
    }
}
