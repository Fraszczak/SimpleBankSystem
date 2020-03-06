using SimpleBankSystem.Models.Database.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SimpleBankSystem.Models.Database.EntityConfiguratioin.LoginToConfiguration
{
    class InfoTableConfiguration : EntityTypeConfiguration<InfoTable>
    {
        public InfoTableConfiguration()
        {
            // Configure the table name
            ToTable("InfoTable");

            // Configure the primary key
            HasKey(c => c.Id);

            // Configure the property Name
            Property(c => c.Name)
                .HasMaxLength(100);

            // Configure the property Description
            Property(c => c.Description)
                .HasMaxLength(2000);

        }
    }
}
