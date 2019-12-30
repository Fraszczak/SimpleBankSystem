using SimpleBankSystem.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SimpleBankSystem.Persistance.EntityConfiguratioin.CreditCardTableConfiguration
{
    public class CurrentAccountTableConfiguration : EntityTypeConfiguration<CurrentAccountTable>
    {
        public CurrentAccountTableConfiguration()
        {
            ToTable("CurrentAccountTable");

            HasKey(c => c.ID);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Value)
                .IsRequired();

            Property(c => c.Ballance)
                .IsRequired();

          
                

      
        }
    }
}
