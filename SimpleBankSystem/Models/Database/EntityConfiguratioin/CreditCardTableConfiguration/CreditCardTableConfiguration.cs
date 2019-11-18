using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankSystem.Models.Database.EntityConfiguratioin.CreditCardTableConfiguration
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
