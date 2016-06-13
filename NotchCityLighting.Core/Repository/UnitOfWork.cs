using NotchCityLighting.Common.DataAccess;
using NotchCityLighting.Core.Interfaces;

namespace NotchCityLighting.Core.Repository
{
    public class UnitOfWork : UnitOfWorkBase, IUnitOfWork
    {
        public UnitOfWork(INotchCityLightingContext context) //inject other contexts here
        {
            _DbContexts.Add(context);
        }
    }
}
