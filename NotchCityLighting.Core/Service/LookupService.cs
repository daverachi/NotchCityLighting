using NotchCityLighting.Core.Interfaces;
using NotchCityLighting.Core.Models;
using System.Collections.Generic;

namespace NotchCityLighting.Core.Service
{
    public class LookupService : ILookupService
    {
        private ILightRepository _lightRepository;
        private ILightPartRepository _lightPartRepository;
        private IPartRepository _partRepository;

        public LookupService(
            ILightRepository lightRepository,
            ILightPartRepository lightPartRepository,
            IPartRepository partRepository)
        {
            _lightRepository = lightRepository;
            _lightPartRepository = lightPartRepository;
            _partRepository = partRepository;
        }

        public IEnumerable<Light> GetLights()
        {
            return _lightRepository.Get();
        }

        public Light GetLightById(int id)
        {
            return _lightRepository.GetByLightId(id);
        }

        public IEnumerable<Part> GetParts()
        {
            return _partRepository.Get();
        }

        public Part GetPartById(int id)
        {
            return _partRepository.GetByPartId(id);
        }

        public IEnumerable<LightPart> GetLightPartsByLightId(int id)
        {
            return _lightPartRepository.GetLightPartsByLightId(id);
        }
    }
}
