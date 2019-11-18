using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankSystem.Models.Database.EntityConfiguratioin.SaveAccountTableConfiguration
{
    public class SaveAccountTableConfiguration : EntityTypeConfiguration<SaveAccountTable>
    {
        public SaveAccountTableConfiguration()
        {
            ToTable("SaveAccountTable");

            HasKey(c => c.ID);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Value)
                .IsRequired();

            Property(c => c.Ballance)
                .IsRequired();

            HasRequired(a => a.CurrentAccount)
                .WithMany(b => b.SaveAccount)
                .HasForeignKey(c => c.CurrentAccountID)
                .WillCascadeOnDelete(false);

        
                
                
                
            
             
        }
    }
}
