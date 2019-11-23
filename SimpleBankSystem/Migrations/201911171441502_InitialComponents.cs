namespace SimpleBankSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialComponents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreditCardTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ballance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CurentAccountID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CurrentAccountTable", t => t.CurentAccountID)
                .Index(t => t.CurentAccountID);
            
            CreateTable(
                "dbo.CurrentAccountTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ballance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CurrenciesTableID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CurrenciesTable", t => t.CurrenciesTableID)
                .Index(t => t.CurrenciesTableID);
            
            CreateTable(
                "dbo.CurrenciesTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SaveAccountTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ballance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CurrentAccountID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CurrentAccountTable", t => t.CurrentAccountID)
                .Index(t => t.CurrentAccountID);
            
            CreateTable(
                "dbo.InvestmentTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Currencies_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CurrenciesTable", t => t.Currencies_ID)
                .Index(t => t.Currencies_ID);
            
            CreateTable(
                "dbo.JobTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Description = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LocationTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LoginToTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RegTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Description = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.JobsLocations",
                c => new
                    {
                        LocationsID = c.Int(nullable: false),
                        JobsID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.LocationsID, t.JobsID })
                .ForeignKey("dbo.LocationTable", t => t.LocationsID, cascadeDelete: true)
                .ForeignKey("dbo.JobTable", t => t.JobsID, cascadeDelete: true)
                .Index(t => t.LocationsID)
                .Index(t => t.JobsID);
            
        }
        
        


        public override void Down()
        {
            DropForeignKey("dbo.JobsLocations", "JobsID", "dbo.JobTable");
            DropForeignKey("dbo.JobsLocations", "LocationsID", "dbo.LocationTable");
            DropForeignKey("dbo.InvestmentTable", "Currencies_ID", "dbo.CurrenciesTable");
            DropForeignKey("dbo.CreditCardTable", "CurentAccountID", "dbo.CurrentAccountTable");
            DropForeignKey("dbo.SaveAccountTable", "CurrentAccountID", "dbo.CurrentAccountTable");
            DropForeignKey("dbo.CurrentAccountTable", "CurrenciesTableID", "dbo.CurrenciesTable");
            DropIndex("dbo.JobsLocations", new[] { "JobsID" });
            DropIndex("dbo.JobsLocations", new[] { "LocationsID" });
            DropIndex("dbo.InvestmentTable", new[] { "Currencies_ID" });
            DropIndex("dbo.SaveAccountTable", new[] { "CurrentAccountID" });
            DropIndex("dbo.CurrentAccountTable", new[] { "CurrenciesTableID" });
            DropIndex("dbo.CreditCardTable", new[] { "CurentAccountID" });
            DropTable("dbo.JobsLocations");
            DropTable("dbo.RegTable");
            DropTable("dbo.LoginToTable");
            DropTable("dbo.LocationTable");
            DropTable("dbo.JobTable");
            DropTable("dbo.InvestmentTable");
            DropTable("dbo.SaveAccountTable");
            DropTable("dbo.CurrenciesTable");
            DropTable("dbo.CurrentAccountTable");
            DropTable("dbo.CreditCardTable");
        }
    }
}
