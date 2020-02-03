using SimpleBankSystem.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SimpleBankSystem.Persistance.EntityConfiguratioin.CreditCardTableConfiguration
{
    public class CreditCardTableConfiguration : EntityTypeConfiguration<CreditCardTable>
    {
        public CreditCardTableConfiguration()
        {
            // Configure the table name
            ToTable("CreditCardTable");

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
            //HasRequired(s => s.CurrentAccount)
            //    .WithMany(g => g.CreditCard)
            //    .HasForeignKey(a => a.CurentAccountID)
            //    .WillCascadeOnDelete(false);
          //  HasRequired(c => c.Name);
        }
    }
}
