using SimpleBankSystem.Core.Domain;
using SimpleBankSystem.Models.Database.EntityConfiguratioin.LoginToConfiguration;
using SimpleBankSystem.Models.Database.EntityConfiguratioin.SaveAccountTableConfiguration;
using SimpleBankSystem.Persistance.EntityConfiguratioin.CreditCardTableConfiguration;
using System.Data.Entity;

namespace SimpleBankSystem.Persistance
{
    public partial class PlutoContext : DbContext
    {
        public virtual DbSet<LoginToTable> LoginDbSet { get; set; }
        public virtual DbSet<CreditCardTable> CreditCardDbSet { get; set; }
        public virtual DbSet<CurrentAccountTable> CurrentAccountDbSet { get; set; }
        public virtual DbSet<SaveAccountTable> SaveAccountDbSet { get; set; }
        public virtual DbSet<InfoTable> InfoDBSet { get; set; }
        public virtual DbSet<InvestmentTable> InvestmentDbSetSet { get; set; }
     

        public PlutoContext()
            : base(nameOrConnectionString: "DefaultConnection")
        {
            // wylacza lazy loading
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LoginToTableConfiguration());
            modelBuilder.Configurations.Add(new InfoTableConfiguration());
            modelBuilder.Configurations.Add(new SaveAccountTableConfiguration());
            modelBuilder.Configurations.Add(new InvestmentTableConfiguration());
            modelBuilder.Configurations.Add(new CurrentAccountTableConfiguration());
            modelBuilder.Configurations.Add(new CreditCardTableConfiguration());
        }


    }
}