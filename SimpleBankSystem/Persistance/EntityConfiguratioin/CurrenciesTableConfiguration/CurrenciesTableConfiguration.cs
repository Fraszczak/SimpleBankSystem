using SimpleBankSystem.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SimpleBankSystem.Persistance.EntityConfiguratioin.CreditCardTableConfiguration
{
    public class CurrenciesTableConfiguration : EntityTypeConfiguration<CurrenciesTable>
    {
        public CurrenciesTableConfiguration()
        {
            ToTable("CurrenciesTable");

            HasKey(c => c.ID);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);


            HasMany(a => a.CurrentAccountTable)
                .WithRequired(a => a.Curriences)
                .HasForeignKey(a => a.CurrenciesTableID)
                .WillCascadeOnDelete(false);

        }
    }
}
