using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankSystem.Models.Database.EntityConfiguratioin.InvestmentTableConfiguration
{
    public class InvestmentTableConfiguration : EntityTypeConfiguration<InvestmentTable>
    {
        public InvestmentTableConfiguration()
        {
            ToTable("InvestmentTable");

            HasKey(c => c.ID);

            Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired();

            
        }

    }
}
