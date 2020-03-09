
using SimpleBankSystem.Models.Database.Core.Domain;
using SimpleBankSystem.Models.Database.EntityConfiguratioin.LoginToConfiguration;
using SimpleBankSystem.Models.Database.Persistance.EntityConfiguratioin;
using System.Data.Entity;

namespace SimpleBankSystem.Persistance
{
    partial class SBSDatabaseContext : DbContext
    {
        
        public  DbSet<InfoTable> InfoTableDbSet { get; set; }
        //public virtual DbSet<TypeOfAcount> TypeOfAcountDbSet { get; set; }
        public  DbSet<UserTable> UserTableDbSet { get; set; }
        public  DbSet<AccountHistoryTable> AccountHistoryTableDbSet { get; set; }
        public  DbSet<Account> AccountDbSet { get; set; } 
     

        public SBSDatabaseContext()
            : base(nameOrConnectionString: "DefaultConnection")
        {
            // Lazy loading off
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Configurations.Add(entityTypeConfiguration: new InfoTableConfiguration());
            modelBuilder.Configurations.Add(entityTypeConfiguration: new AccountConfiguration());
            modelBuilder.Configurations.Add(entityTypeConfiguration: new AccountHistoryTableConfiguration());
            modelBuilder.Configurations.Add(entityTypeConfiguration: new UserTableConfiguration());
        }


    }
}