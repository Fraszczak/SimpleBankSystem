using SimpleBankSystem.Models.Database.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SimpleBankSystem.Models.Database.Persistance.EntityConfiguratioin
{
    class AccountConfiguration : EntityTypeConfiguration<Account>
    {
        public AccountConfiguration()
        {
            // Configure the table name
            ToTable("AccountTable");

            // Configure the primary key
            HasKey(c => c.Id);

            Property(c => c.Balance)
                .IsRequired()
                .HasPrecision(4, 2);

            Property(c => c.DateTime)
                .IsRequired();

            Property(c => c.Type)
               .IsRequired();

          
            HasRequired(c => c.User)
                .WithMany(c => c.Accounts)
                .WillCascadeOnDelete(true);
        }
    }
}
