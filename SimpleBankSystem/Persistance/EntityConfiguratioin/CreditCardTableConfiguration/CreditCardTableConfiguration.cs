using SimpleBankSystem.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SimpleBankSystem.Persistance.EntityConfiguratioin.CreditCardTableConfiguration
{
    public class CreditCardTableConfiguration : EntityTypeConfiguration<CreditCardTable>
    {
        public CreditCardTableConfiguration()
        {
            ToTable("CreditCardTable");

            HasKey(c => c.ID);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Value)
                .IsRequired();

            Property(c => c.Ballance)
                .IsRequired();

            HasRequired(s => s.CurrentAccount)
                .WithMany(g => g.CreditCard)
                .HasForeignKey(a => a.CurentAccountID)
                .WillCascadeOnDelete(false);
        }
    }
}
