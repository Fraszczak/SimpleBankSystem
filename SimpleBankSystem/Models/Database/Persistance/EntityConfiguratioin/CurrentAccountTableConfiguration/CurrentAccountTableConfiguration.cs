using SimpleBankSystem.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SimpleBankSystem.Persistance.EntityConfiguratioin.CreditCardTableConfiguration
{
    public class CurrentAccountTableConfiguration : EntityTypeConfiguration<CurrentAccountTable>
    {
        public CurrentAccountTableConfiguration()
        {
            // Configure the table name
            ToTable("CurrentAccountTable");

            // Configure the primary key
            HasKey(c => c.ID);

            // Configure the property ID
            Property(c => c.ID)
                .IsRequired();

            // Configure the property Name
            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Configure the property Value
            Property(c => c.Value)
                .IsRequired();

         

            // Map one-to-zero or one relationship
          //  HasRequired(c => c.Name);


        }
    }
}
