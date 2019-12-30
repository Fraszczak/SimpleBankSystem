using SimpleBankSystem.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SimpleBankSystem.Persistance.EntityConfiguratioin.CreditCardTableConfiguration
{
    public class InvestmentTableConfiguration : EntityTypeConfiguration<InvestmentTable>
    {
        public InvestmentTableConfiguration()
        {
            ToTable("InvestmentTable");

            HasKey(c => c.ID);

            Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired();

            
        }

    }
}
