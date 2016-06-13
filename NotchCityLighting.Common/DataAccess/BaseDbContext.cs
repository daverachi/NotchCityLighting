using NotchCityLighting.Common.Config;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NotchCityLighting.Common.DataAccess
{
    public abstract class BaseDbContext : DbContext, IDbContext
    {
        public BaseDbContext() : base()
        {
            (this as IObjectContextAdapter).ObjectContext.CommandTimeout = CommonSettingsConfigSection.GetSection().DbContextCommandTimeout;
            ObjectContext().ContextOptions.UseCSharpNullComparisonBehavior = true;
        }

        public BaseDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            (this as IObjectContextAdapter).ObjectContext.CommandTimeout = 1200;
        }

        public override int SaveChanges()
        {
            SetAuditFields();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            SetAuditFields();
            return base.SaveChangesAsync(cancellationToken);
        }

        public ObjectContext ObjectContext()
        {
            return (this as IObjectContextAdapter).ObjectContext;
        }

        private void SetAuditFields()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                var baseEntity = entry.Entity as EntityBase;
                if (baseEntity == null)
                    continue;

                if (entry.State == EntityState.Added)
                {
                    baseEntity.CreateDateTime = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    baseEntity.ModifiedDateTime = DateTime.Now;
                }
            }
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public bool SetExists<T>() where T : class
        {
            return ObjectContext().MetadataWorkspace.GetItems<EntityType>(DataSpace.CSpace).Any(e => e.Name == typeof(T).Name);
        }
    }
}
