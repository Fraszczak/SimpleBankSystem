using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankSystem.Models.Database.EntityConfiguratioin.CurrenciesTableConfiguration
{
    public class CurrenciesTableConfiguration : EntityTypeConfiguration<CurrenciesTable>
    {
        public CurrenciesTableConfiguration()
        {
            ToTable("CurrenciesTable");

            HasKey(c => c.ID);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            HasMany(a => a.CurrentAccountTable)
                .WithRequired(a => a.Curriences)
                .HasForeignKey(a => a.CurrenciesTableID)
                .WillCascadeOnDelete(false);
                
        }
    }
}
