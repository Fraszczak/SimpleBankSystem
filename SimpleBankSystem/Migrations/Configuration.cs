namespace SimpleBankSystem.Migrations
{
    using SimpleBankSystem.Models.Database.Core.Domain;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleBankSystem.Persistance.SBSDatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SimpleBankSystem.Persistance.SBSDatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            #region Add Info Table
            var infos = new Dictionary<string, InfoTable>
                        {
                            {"Legal Info", new InfoTable{Id = Guid.NewGuid(), Name = "Legal Info", Description = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
                            Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
                            when an unknown printer took a galley of type and scrambled it to make a type specimen book." } },
                            {"Seciurity", new InfoTable{Id = Guid.NewGuid(), Name = "Seciurity", Description = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
                            Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
                            when an unknown printer took a galley of type and scrambled it to make a type specimen book." } },
                            {"Accessibility", new InfoTable{Id = Guid.NewGuid(), Name = "Accessibility", Description = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
                            Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
                            when an unknown printer took a galley of type and scrambled it to make a type specimen book." } },
                            {"AccountWindowTitle", new InfoTable{Id = Guid.NewGuid(), Name = "AccountWindowTitle", Description = "SimpleBankSystem - Account"} },
                             {"CreateWindowTitle", new InfoTable{Id = Guid.NewGuid(), Name = "CreateAccountWindowTitle", Description = "SimpleBankSystem - Create Account"} },
                             {"InfoWindowTitle", new InfoTable{Id = Guid.NewGuid(), Name = "InfoWindowTitle", Description = "SimpleBankSystem - Info"} },
                             {"InvestmentWindowTitle", new InfoTable{Id = Guid.NewGuid(), Name = "InvestmentWindowTitle", Description = "SimpleBankSystem - Investment"} },
                             {"MainWindowTitle", new InfoTable{Id = Guid.NewGuid(), Name = "MainWindowTitle", Description = "SimpleBankSystem"} }
                        };
            foreach (var info in infos.Values)
                context.InfoTableDbSet.AddOrUpdate(t => t.Id, info);
            #endregion

        }
    }
}
