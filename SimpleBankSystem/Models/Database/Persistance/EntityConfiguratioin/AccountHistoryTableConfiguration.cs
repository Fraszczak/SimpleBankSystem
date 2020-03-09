using SimpleBankSystem.Models.Database.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SimpleBankSystem.Models.Database.Persistance.EntityConfiguratioin
{
    public class AccountHistoryTableConfiguration : EntityTypeConfiguration<AccountHistoryTable>
    {
        public AccountHistoryTableConfiguration()
        {
            // Configure the table name
            ToTable("AccountHistoryTable");

            // Configure the primary key
            HasKey(c => c.Id);

            Property(c => c.Value)
                .IsRequired();

            Property(c => c.TransactionDate)
                .IsRequired();

            Property(c => c.TransactionName)
                .IsRequired();

            

            HasRequired(c => c.Account)
                .WithRequiredPrincipal(c => c.AccountHistory)
                .WillCascadeOnDelete(true);
        }
    }
}
