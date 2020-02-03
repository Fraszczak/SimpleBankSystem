using SimpleBankSystem.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SimpleBankSystem.Models.Database.EntityConfiguratioin.LoginToConfiguration
{
    public class InfoTableConfiguration : EntityTypeConfiguration<InfoTable>
    {
        public InfoTableConfiguration()
        {
            // Configure the table name
            ToTable("InfoTable");

            // Configure the primary key
            HasKey(c => c.ID);

            // Configure the property Name
            Property(c => c.Name)
                .HasMaxLength(100);

            // Configure the property Description
            Property(c => c.Description)
                .HasMaxLength(2000);

            // Map one-to-zero or one relationship
          //  HasRequired(c => c.Name);
        }

    }
}
