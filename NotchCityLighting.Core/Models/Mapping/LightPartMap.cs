using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NotchCityLighting.Core.Models.Mapping
{
    public class LightPartMap : EntityTypeConfiguration<LightPart>
    {
        public LightPartMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("LightPart");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.LightId).HasColumnName("LightId");
            this.Property(t => t.PartId).HasColumnName("PartId");
            this.Property(t => t.CreateDateTime).HasColumnName("CreateDateTime");

            // Relationships
            this.HasRequired(t => t.Light)
                .WithMany(t => t.LightParts)
                .HasForeignKey(d => d.LightId);
            this.HasRequired(t => t.Part)
                .WithMany(t => t.LightParts)
                .HasForeignKey(d => d.PartId);

        }
    }
}
