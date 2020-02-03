using SimpleBankSystem.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SimpleBankSystem.Models.Database.EntityConfiguratioin.LoginToConfiguration
{
    public class LoginToTableConfiguration : EntityTypeConfiguration<LoginToTable>
    {
        public LoginToTableConfiguration()
        {
            // Configure the table name
            ToTable("LoginToTable");

            // Configure the primary key
            HasKey(c => c.ID);

            // Configure the property ID
            Property(c => c.ID)
                .IsRequired();

            // Configure the property Login
            Property(c => c.Login)
                .IsRequired()
                .HasMaxLength(50);

            // Configure the property Password
            Property(c => c.Password)
                .IsRequired()
                .HasMaxLength(50);

            // Map one-to-zero or one relationship
           // HasRequired(c => c.Login);
        }
    }
}
