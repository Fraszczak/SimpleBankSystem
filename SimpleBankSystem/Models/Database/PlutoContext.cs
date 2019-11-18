using SimpleBankSystem.Models.Database.EntityConfiguratioin.CreditCardTableConfiguration;
using SimpleBankSystem.Models.Database.EntityConfiguratioin.CurrenciesTableConfiguration;
using SimpleBankSystem.Models.Database.EntityConfiguratioin.CurrentAccountTableConfiguration;
using SimpleBankSystem.Models.Database.EntityConfiguratioin.InvestmentTableConfiguration;
using SimpleBankSystem.Models.Database.EntityConfiguratioin.JobConfigration;
using SimpleBankSystem.Models.Database.EntityConfiguratioin.LocationTableConfiguration;
using SimpleBankSystem.Models.Database.EntityConfiguratioin.LoginToConfiguration;
using SimpleBankSystem.Models.Database.EntityConfiguratioin.SaveAccountTableConfiguration;
using System.Data.Entity;

namespace SimpleBankSystem.Models
{
    public partial class PlutoContext : DbContext
    {
        public virtual DbSet<LoginToTable> LoginDbSet { get; set; }
        public virtual DbSet<CurrenciesTable> CurrenciesDbSet { get; set; }
        public virtual DbSet<CreditCardTable> CreditCardDbSet { get; set; }
        public virtual DbSet<CurrentAccountTable> CurrentAccountDbSet { get; set; }
        public virtual DbSet<SaveAccountTable> SaveAccountDbSet { get; set; }
        public virtual DbSet<RegTable> RegDbSet { get; set; }
        public virtual DbSet<InvestmentTable> InvestmentDbSetSet { get; set; }
        public virtual DbSet<LocationsTable> LocationsDbSet { get; set; }
        public virtual DbSet<JobTable> JobDbSet { get; set; }

        public PlutoContext()
            : base("name=DefaultConnection")
        { 
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LoginToTableConfiguration());
            modelBuilder.Configurations.Add(new RegTableConfiguration());
            modelBuilder.Configurations.Add(new SaveAccountTableConfiguration());
            modelBuilder.Configurations.Add(new JobTableConfiguration());
            modelBuilder.Configurations.Add(new LocationsTableConfiguration());
            modelBuilder.Configurations.Add(new InvestmentTableConfiguration());
            modelBuilder.Configurations.Add(new CurrentAccountTableConfiguration());
            modelBuilder.Configurations.Add(new CurrenciesTableConfiguration());
            modelBuilder.Configurations.Add(new CreditCardTableConfiguration());
        }


    }
}