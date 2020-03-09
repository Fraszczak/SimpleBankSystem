using SimpleBankSystem.Models.Database.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SimpleBankSystem.Models.Database.Persistance.EntityConfiguratioin
{
    class UserTableConfiguration : EntityTypeConfiguration<UserTable>
    {
        public UserTableConfiguration()
        {
            // Configure the table name
            ToTable("UserTable");

            // Configure the primary key
            HasKey(c => c.Id);

            Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(3);

            Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.LastName)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.EmailAddress)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.PhoneNumber)
                .IsOptional()
                .HasMaxLength(13);

            Property(c => c.Login)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Password)
                .IsRequired()
                .HasMaxLength(50);

   
            
        }
    }

}