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

            #region InfoView

            

            #endregion


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

            //#region Add SaveAccount Table
            //var saveAccountValues = new Dictionary<string, SaveAccountTable>
            //{
            //    {"Value_1", new SaveAccountTable{ID = Guid.NewGuid(), Name = "new car", Value = 1000,  } }, 
            //    { "Value_2", new SaveAccountTable { ID = Guid.NewGuid(), Name = "new car", Value = 1000, }} 
            //};


            //foreach (var saveAccountValue in saveAccountValues.Values)
            //    context.SaveAccountDbSet.AddOrUpdate(t => t.ID, saveAccountValue);
            //#endregion
        }
    }
}
