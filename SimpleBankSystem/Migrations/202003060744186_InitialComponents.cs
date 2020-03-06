namespace SimpleBankSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialComponents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Balance = c.Decimal(precision: 18, scale: 2),
                        DateTime = c.DateTime(nullable: false),
                        Type = c.Int(nullable: false),
                        User_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserTables", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AccountHistoryTables",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TransactionDate = c.DateTime(nullable: false),
                        TransactionName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.UserTables",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                        PhoneNumber = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LoginToTables",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserTables", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.InfoTables",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "User_Id", "dbo.UserTables");
            DropForeignKey("dbo.LoginToTables", "Id", "dbo.UserTables");
            DropForeignKey("dbo.AccountHistoryTables", "Id", "dbo.Accounts");
            DropIndex("dbo.LoginToTables", new[] { "Id" });
            DropIndex("dbo.AccountHistoryTables", new[] { "Id" });
            DropIndex("dbo.Accounts", new[] { "User_Id" });
            DropTable("dbo.InfoTables");
            DropTable("dbo.LoginToTables");
            DropTable("dbo.UserTables");
            DropTable("dbo.AccountHistoryTables");
            DropTable("dbo.Accounts");
        }
    }
}
