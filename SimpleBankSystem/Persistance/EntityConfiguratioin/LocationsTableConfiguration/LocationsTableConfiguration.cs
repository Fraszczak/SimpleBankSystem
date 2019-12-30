using SimpleBankSystem.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SimpleBankSystem.Models.Database.EntityConfiguratioin.LocationTableConfiguration
{
    public class LocationsTableConfiguration : EntityTypeConfiguration<LocationsTable>
    {
        public LocationsTableConfiguration()
        {
            ToTable("LocationTable");

            HasKey(c => c.ID);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50)
                ;
            Property(c => c.Description)
               .IsRequired()
               .HasMaxLength(500);

            HasMany(s => s.Jobs)
                 .WithMany(a => a.Locations)
                 .Map(l =>
                 {
                     l.MapLeftKey("LocationsID");
                     l.MapRightKey("JobsID");
                     l.ToTable("JobsLocations");
                 });
        }
    }
}
