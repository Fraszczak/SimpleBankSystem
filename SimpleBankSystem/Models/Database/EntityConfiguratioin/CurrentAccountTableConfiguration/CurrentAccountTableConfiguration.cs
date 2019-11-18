using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankSystem.Models.Database.EntityConfiguratioin.CurrentAccountTableConfiguration
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
