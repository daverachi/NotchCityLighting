using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NotchCityLighting.Core.Models.Mapping
{
    public class PartMap : EntityTypeConfiguration<Part>
    {
        public PartMap()
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
                .HasMaxLength(150);

            this.Property(t => t.ItemNumber)
                .HasMaxLength(60);

            this.Property(t => t.LocationOfPurchase)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Part");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.MaterialType).HasColumnName("MaterialType");
            this.Property(t => t.MaximumWattage).HasColumnName("MaximumWattage");
            this.Property(t => t.Cost).HasColumnName("Cost");
            this.Property(t => t.ItemNumber).HasColumnName("ItemNumber");
            this.Property(t => t.LocationOfPurchase).HasColumnName("LocationOfPurchase");
            this.Property(t => t.Photo).HasColumnName("Photo");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.Length).HasColumnName("Length");
            this.Property(t => t.Width).HasColumnName("Width");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.CreateDateTime).HasColumnName("CreateDateTime");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");

            // Relationships
            this.HasRequired(t => t.MaterialType1)
                .WithMany(t => t.Parts)
                .HasForeignKey(d => d.MaterialType);

        }
    }
}
