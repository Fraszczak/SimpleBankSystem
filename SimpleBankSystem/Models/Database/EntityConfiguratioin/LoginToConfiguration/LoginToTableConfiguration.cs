using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankSystem.Models.Database.EntityConfiguratioin.LoginToConfiguration
{
    public class LoginToTableConfiguration : EntityTypeConfiguration<LoginToTable>
    {
        public LoginToTableConfiguration()
        {
            ToTable("LoginToTable");

            HasKey(c => c.ID); // ustawia primary key ?

            Property(c => c.Login)
                .IsRequired() // sprawia ze nie moze byc nullem
                .HasMaxLength(50);

            Property(c => c.Password)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
