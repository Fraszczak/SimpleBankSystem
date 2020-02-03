using SimpleBankSystem.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SimpleBankSystem.Models.Database.EntityConfiguratioin.SaveAccountTableConfiguration
{
    public class SaveAccountTableConfiguration : EntityTypeConfiguration<SaveAccountTable>
    {
        public SaveAccountTableConfiguration()
        {
            // Configure the table name
            ToTable("SaveAccountTable");

            // Configure the primary key
            HasKey(c => c.ID);

            // Configure the property Name
            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Configure the property Value
            Property(c => c.Value)
                .IsRequired();



            // Map one-to-zero or one relationship
            //HasRequired(c => c.Name);

            //HasRequired(a => a.CurrentAccount)
            //    .WithMany(b => b.SaveAccount)
            //    .HasForeignKey(c => c.CurrentAccountID)
            //    .WillCascadeOnDelete(false);

        
                
                
                
            
             
        }
    }
}
