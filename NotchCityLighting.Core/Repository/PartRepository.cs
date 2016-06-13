using NotchCityLighting.Common.DataAccess;
using NotchCityLighting.Core.Interfaces;
using NotchCityLighting.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace NotchCityLighting.Core.Repository
{
    public class PartRepository : BaseRepository<Part>, IPartRepository
    {
        private IUnitOfWork _UnitOfWork;
        public PartRepository(IUnitOfWork UnitOfWork)
            : base(UnitOfWork)
        {
            _UnitOfWork = UnitOfWork;
        }

        public IEnumerable<Part> Get()
        {
            return GetQueryable();
        }

        public Part GetByPartId(int id)
        {
            return GetQueryable().SingleOrDefault(m => m.Id.Equals(id));
        }

        public bool CreatePart(Part newPart)
        {
            base.Add(newPart);
            return _UnitOfWork.SaveChanges() > 0;
        }

        public bool UpdatePart(Part updatedPart)
        {
            base.Update(updatedPart);
            return _UnitOfWork.SaveChanges() > 0;
        }

        public bool DeletePart(int id)
        {
            Part deletePart = GetByPartId(id);
            base.Delete(deletePart);
            return _UnitOfWork.SaveChanges() > 0;
        }
    }
}
