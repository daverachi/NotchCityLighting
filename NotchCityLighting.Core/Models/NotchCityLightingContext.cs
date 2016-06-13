using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using NotchCityLighting.Core.Models.Mapping;
using NotchCityLighting.Common.DataAccess;
using NotchCityLighting.Core.Interfaces;

namespace NotchCityLighting.Core.Models
{
    public partial class NotchCityLightingContext : BaseDbContext, INotchCityLightingContext
    {
        static NotchCityLightingContext()
        {
            Database.SetInitializer<NotchCityLightingContext>(null);
        }

        public NotchCityLightingContext()
            : base("Name=NotchCityLightingContext")
        {
        }

        public DbSet<Light> Lights { get; set; }
        public DbSet<LightPart> LightParts { get; set; }
        public DbSet<MaterialType> MaterialTypes { get; set; }
        public DbSet<Part> Parts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LightMap());
            modelBuilder.Configurations.Add(new LightPartMap());
            modelBuilder.Configurations.Add(new MaterialTypeMap());
            modelBuilder.Configurations.Add(new PartMap());
        }
    }
}
