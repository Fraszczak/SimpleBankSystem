using SimpleBankSystem.Models.Database.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SimpleBankSystem.Models.Database.EntityConfiguratioin.LoginToConfiguration
{
    class LoginToTableConfiguration : EntityTypeConfiguration<LoginToTable>
    {
        public LoginToTableConfiguration()
        {
            // Configure the table name
            ToTable("LoginToTable");

            // Configure the primary key
            HasKey(c => c.Id);

            // Configure the property Login
            Property(c => c.Login)
                .IsRequired()
                .HasMaxLength(50);

            // Configure the property Password
            Property(c => c.Password)
                .IsRequired()
                .HasMaxLength(50);

            // Configure the relationship one to one between UserTable and LoginToTable. Is enoght if one of them has this option in their configuration file
            HasRequired(c => c.UserTable)
                .WithRequiredPrincipal(c => c.LoginTo)
                .WillCascadeOnDelete(true);
        }
    }
}
