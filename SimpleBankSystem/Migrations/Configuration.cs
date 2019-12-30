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

            #region Add Reg Table
            var regs = new Dictionary<string, RegTable>
            {
                {"Legal Info1", new RegTable{ID = Guid.NewGuid(), Name = "Legal Info", Description = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
                Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
                when an unknown printer took a galley of type and scrambled it to make a type specimen book.
                It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.
                It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
                and more recently with desktop publishing software like Aldus PageMaker including versions of 1Lorem Ipsum." } },
                {"Seciurity2", new RegTable{ID = Guid.NewGuid(), Name = "Seciurity", Description = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
                Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
                when an unknown printer took a galley of type and scrambled it to make a type specimen book.
                It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.
                It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
                and more recently with desktop publishing software like Aldus PageMaker including versions of 2Lorem Ipsum." } },
                {"Accessibility3", new RegTable{ID = Guid.NewGuid(), Name = "Accessibility", Description = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
                Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
                when an unknown printer took a galley of type and scrambled it to make a type specimen book.
                It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.
                It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
                and more recently with desktop publishing software like Aldus PageMaker including versions of 3Lorem Ipsum." } }
            };
            

            foreach (var reg in regs.Values)
                context.RegDbSet.AddOrUpdate(t => t.ID, reg);
            #endregion

            #region Add Login Table
            var logins = new Dictionary<string, LoginToTable>
            {
                {"Admin", new LoginToTable{ID = Guid.NewGuid(), Login = "Admin", Password = "Pass" } },
            };


            foreach (var login in logins.Values)
                context.LoginDbSet.AddOrUpdate(t => t.ID, login);
            #endregion

            //#region Add SaveAccount Table
            //var saveAccountValues = new Dictionary<string, SaveAccountTable>
            //{
            //    {"Value_1", new SaveAccountTable{ID = new Guid(), Name = "new car", Value = 1000,  } }

            //};


            //foreach (var saveAccountValue in saveAccountValues.Values)
            //    context.LoginDbSet.AddOrUpdate(t => t.ID, saveAccountValue);
            //#endregion
        }
    }
}
