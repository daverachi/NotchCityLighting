using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotchCityLighting.Common.DataAccess
{
    public class Repository<T> : BaseRepository<T>, IRepository<T> where T : class
    {
        public Repository(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
