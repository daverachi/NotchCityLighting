using NotchCityLighting.Common.DataAccess;
using NotchCityLighting.Core.Interfaces;
using NotchCityLighting.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotchCityLighting.Core.Repository
{
    public class LightRepository : BaseRepository<Light>, ILightRepository
    {
        private IUnitOfWork _UnitOfWork;
        public LightRepository(IUnitOfWork UnitOfWork)
            : base(UnitOfWork)
        {
            _UnitOfWork = UnitOfWork;
        }

        public IEnumerable<Light> Get()
        {
            return GetQueryable();
        }

        public Light GetByLightId(int id)
        {
            return GetQueryable().SingleOrDefault(m => m.Id.Equals(id));
        }

        public bool CreateLight(Light newLight)
        {
            base.Add(newLight);
            return _UnitOfWork.SaveChanges() > 0;
        }

        public bool UpdateLight(Light updatedLight)
        {
            base.Update(updatedLight);
            return _UnitOfWork.SaveChanges() > 0;
        }

        public bool DeleteLight(Light deletedLight)
        {
            base.Delete(deletedLight);
            return _UnitOfWork.SaveChanges() > 0;
        }
    }
}
