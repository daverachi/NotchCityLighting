using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NotchCityLighting.Core.Models.Mapping
{
    public class LightMap : EntityTypeConfiguration<Light>
    {
        public LightMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Light");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Photo).HasColumnName("Photo");
            this.Property(t => t.SalePrice).HasColumnName("SalePrice");
            this.Property(t => t.SoldPrice).HasColumnName("SoldPrice");
            this.Property(t => t.CreateDateTime).HasColumnName("CreateDateTime");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");
            this.Property(t => t.SoldDateTime).HasColumnName("SoldDateTime");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
        }
    }
}
