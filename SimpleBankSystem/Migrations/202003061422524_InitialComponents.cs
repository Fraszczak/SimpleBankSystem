namespace SimpleBankSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialComponents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountTable",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Balance = c.Decimal(nullable: false, precision: 4, scale: 2),
                        DateTime = c.DateTime(nullable: false),
                        Type = c.Int(nullable: false),
                        UserTableId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountHistoryTable", t => t.Id, cascadeDelete: true)
                .ForeignKey("dbo.UserTable", t => t.UserTableId, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.UserTableId);
            
            CreateTable(
                "dbo.AccountHistoryTable",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TransactionDate = c.DateTime(nullable: false),
                        TransactionName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserTable",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(nullable: false, maxLength: 3),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        EmailAddress = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.String(maxLength: 13),
                        Login = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InfoTable",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 100),
                        Description = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccountTable", "UserTableId", "dbo.UserTable");
            DropForeignKey("dbo.AccountTable", "Id", "dbo.AccountHistoryTable");
            DropIndex("dbo.AccountTable", new[] { "UserTableId" });
            DropIndex("dbo.AccountTable", new[] { "Id" });
            DropTable("dbo.InfoTable");
            DropTable("dbo.UserTable");
            DropTable("dbo.AccountHistoryTable");
            DropTable("dbo.AccountTable");
        }
    }
}
