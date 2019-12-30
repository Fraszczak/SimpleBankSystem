using SimpleBankSystem.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SimpleBankSystem.Models.Database.EntityConfiguratioin.LoginToConfiguration
{
    public class RegTableConfiguration : EntityTypeConfiguration<RegTable>
    {
        public RegTableConfiguration()
        {
            ToTable("RegTable");

            HasKey(c => c.ID);

            Property(c => c.Name)
                .HasMaxLength(100);

            Property(c => c.Description)
                .HasMaxLength(2000);
        }

    }
}
