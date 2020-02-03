namespace SimpleBankSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialComponent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreditCardTable",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        DataTime = c.DateTime(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CurrentAccountTable",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        DataTime = c.DateTime(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.InfoTable",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(maxLength: 100),
                        Description = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.InvestmentTable",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Value = c.Decimal(nullable: false, precision: 8, scale: 2),
                        periotOfTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LoginToTable",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Login = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SaveAccountTable",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        DataTime = c.DateTime(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SaveAccountTable");
            DropTable("dbo.LoginToTable");
            DropTable("dbo.InvestmentTable");
            DropTable("dbo.InfoTable");
            DropTable("dbo.CurrentAccountTable");
            DropTable("dbo.CreditCardTable");
        }
    }
}
