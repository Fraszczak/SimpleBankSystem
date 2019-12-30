using SimpleBankSystem.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SimpleBankSystem.Models.Database.EntityConfiguratioin.LoginToConfiguration
{
    public class LoginToTableConfiguration : EntityTypeConfiguration<LoginToTable>
    {
        public LoginToTableConfiguration()
        {
            ToTable("LoginToTable");

            HasKey(c => c.ID); // ustawia primary key ?
            Property(a => a.ID)
                .IsRequired();

            Property(c => c.Login)
                .IsRequired() // sprawia ze nie moze byc nullem
                .HasMaxLength(50);

            Property(c => c.Password)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
