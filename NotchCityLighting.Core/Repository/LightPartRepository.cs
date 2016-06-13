using NotchCityLighting.Common.DataAccess;
using NotchCityLighting.Core.Interfaces;
using NotchCityLighting.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace NotchCityLighting.Core.Repository
{
    public class LightPartRepository : BaseRepository<LightPart>, ILightPartRepository
    {
        private IUnitOfWork _UnitOfWork;
        public LightPartRepository(IUnitOfWork UnitOfWork)
                : base(UnitOfWork)
        {
            _UnitOfWork = UnitOfWork;
        }

        public IEnumerable<LightPart> Get()
        {
            return GetQueryable();
        }

        public LightPart GetByLightPartId(int id)
        {
            return GetQueryable().SingleOrDefault(m => m.Id.Equals(id));
        }

        public IEnumerable<LightPart> GetLightPartsByLightId(int id)
        {
            return GetQueryable().Where(x => x.LightId == id);
        }

        public bool CreateLightPart(LightPart newLightPart)
        {
            base.Add(newLightPart);
            return _UnitOfWork.SaveChanges() > 0;
        }

        public bool UpdateLightPart(LightPart updatedLightPart)
        {
            base.Update(updatedLightPart);
            return _UnitOfWork.SaveChanges() > 0;
        }

        public bool DeleteLightPart(int id)
        {
            LightPart deleteLightPart = GetByLightPartId(id);
            base.Delete(deleteLightPart);
            return _UnitOfWork.SaveChanges() > 0;
        }
    }
}
