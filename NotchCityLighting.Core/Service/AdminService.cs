using NotchCityLighting.Core.Interfaces;
using NotchCityLighting.Core.Models;

namespace NotchCityLighting.Core.Service
{
    public class AdminService : IAdminService
    {
        private ILightRepository _lightRepository;
        private ILightPartRepository _lightPartRepository;
        private IPartRepository _partRepository;

        public AdminService(
            ILightRepository lightRepository,
            ILightPartRepository lightPartRepository,
            IPartRepository partRepository)
        {
            _lightRepository = lightRepository;
            _lightPartRepository = lightPartRepository;
            _partRepository = partRepository;
        }

        public bool CreateLight(Light light)
        {
            bool created = false;
            if(light != null && !string.IsNullOrWhiteSpace(light.Name))
            {
                if(light.SalePrice < 0)
                {
                    light.SalePrice = 0;
                }
                created = _lightRepository.CreateLight(light);
            }
            return created;
        }

        public bool UpdateLight(Light light)
        {
            bool updated = false;
            if (light != null && light.Id > 0)
            {
                Light existingLight = _lightRepository.GetByLightId(light.Id);
                if(existingLight != null)
                {
                    existingLight.Name = light.Name;
                    existingLight.Description = light.Description;
                    existingLight.Photo = light.Photo;
                    existingLight.SalePrice = light.SalePrice;
                    existingLight.SoldPrice = light.SoldPrice;
                    existingLight.SoldDateTime = light.SoldDateTime;
                    existingLight.IsActive = light.IsActive;
                    updated = _lightRepository.UpdateLight(existingLight);
                }
            }
            return updated;
        }

        public bool DeleteLight(int id)
        {
            bool deleted = false;
            if (id > 0)
            {
                Light existingLight = _lightRepository.GetByLightId(id);
                if(existingLight != null)
                {
                    deleted = _lightRepository.DeleteLight(existingLight);
                }
            }
            return deleted;
        }
    }
}
