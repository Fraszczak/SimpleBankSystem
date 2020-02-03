using SimpleBankSystem.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SimpleBankSystem.Persistance.EntityConfiguratioin.CreditCardTableConfiguration
{
    public class InvestmentTableConfiguration : EntityTypeConfiguration<InvestmentTable>
    {
        public InvestmentTableConfiguration()
        {
            // Configure the table name
            ToTable("InvestmentTable");

            // Configure the primary key
            HasKey(c => c.ID);

            // Configure the property ID
            Property(c => c.ID)
                .IsRequired();

            // Configure the property Name
            Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired();

            // Configure the property Value
            Property(c => c.Value)
                .HasPrecision(8, 2)
                .IsRequired();

            // Configure the property PeriotOfTime
            Property(c => c.periotOfTime)
                .IsRequired();

            // Map one-to-zero or one relationship
          //  HasRequired(c => c.Name);

        }

    }
}
