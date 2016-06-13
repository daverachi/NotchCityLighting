using System.Threading.Tasks;

namespace NotchCityLighting.Common.DataAccess
{
    public interface IUnitOfWork
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();
        IRepository<T> Repository<T>() where T : class;
        IDbContext GetRepositoryContext<T>() where T : class;
    }
}