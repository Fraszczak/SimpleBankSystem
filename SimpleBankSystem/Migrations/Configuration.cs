namespace SimpleBankSystem.Migrations
{
    using SimpleBankSystem.Core.Domain;
    using SimpleBankSystem.Persistance;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<PlutoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PlutoContext context)
        {

            #region Add Info Table
            var infos = new Dictionary<string, InfoTable>
            {
                {"Legal Info1", new InfoTable{ID = Guid.NewGuid(), Name = "Legal Info", Description = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
                Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
                when an unknown printer took a galley of type and scrambled it to make a type specimen book." } },
                {"Seciurity2", new InfoTable{ID = Guid.NewGuid(), Name = "Seciurity", Description = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
                Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
                when an unknown printer took a galley of type and scrambled it to make a type specimen book." } },
                {"Accessibility3", new InfoTable{ID = Guid.NewGuid(), Name = "Accessibility", Description = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
                Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
                when an unknown printer took a galley of type and scrambled it to make a type specimen book." } }
            };
            foreach (var info in infos.Values)
                context.InfoDBSet.AddOrUpdate(t => t.ID, info);
            #endregion

            //#region Add Login Table
            //var logins = new Dictionary<string, LoginToTable>
            //{
            //    {"Admin", new LoginToTable{ID = Guid.NewGuid(), Login = "Admin", Password = "Pass" } },
            //};


            //foreach (var login in logins.Values)
            //    context.LoginDbSet.AddOrUpdate(t => t.ID, login);
            //#endregion

            #region Add CurrentAccount Table
            var currentAccountValues = new Dictionary<string, CurrentAccountTable>
            {
                {"Value_1", new CurrentAccountTable{ID = Guid.NewGuid(), Name = "Food", DataTime = DateTime.Today, Value = 124.19M  } },
                { "Value_2", new CurrentAccountTable { ID = Guid.NewGuid(), Name = "Home insurance", DataTime = DateTime.Today, Value = 79.99M, }}
            };
            
            foreach (var currentAccountValue in currentAccountValues.Values)
                context.CurrentAccountDbSet.AddOrUpdate(t => t.ID, currentAccountValue);
            #endregion

            #region Add SaveAccount Table
            var saveAccountValues = new Dictionary<string, SaveAccountTable>
            {
                {"Value_1", new SaveAccountTable{ID = Guid.NewGuid(), Name = "New car", DataTime = DateTime.Today, Value = 1000,  } },
                { "Value_2", new SaveAccountTable { ID = Guid.NewGuid(), Name = "Insurance bill", DataTime = DateTime.Today, Value = 500, }}
            };

            foreach (var saveAccountValue in saveAccountValues.Values)
                context.SaveAccountDbSet.AddOrUpdate(t => t.ID, saveAccountValue);
            #endregion

            #region Add CreditCardAccount Table
            var creditCardAccountValues = new Dictionary<string, CreditCardTable>
            {
                {"Value_1", new CreditCardTable{ID = Guid.NewGuid(), Name = "New thires", DataTime = DateTime.Today, Value = 699.99M,  } },
                { "Value_2", new CreditCardTable { ID = Guid.NewGuid(), Name = "Girft for mother", DataTime = DateTime.Today, Value = 199M, }}
            };

            foreach (var creditCardAccountValue in creditCardAccountValues.Values)
                context.CreditCardDbSet.AddOrUpdate(t => t.ID, creditCardAccountValue);
            #endregion
        }
    }
}
