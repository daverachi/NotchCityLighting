using NotchCityLighting.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotchCityLighting.Core.Interfaces
{
    public interface IPartRepository
    {
        IEnumerable<Part> Get();
        Part GetByPartId(int id);
        bool CreatePart(Part newPart);
        bool UpdatePart(Part updatedPart);
        bool DeletePart(int id);
    }
}
