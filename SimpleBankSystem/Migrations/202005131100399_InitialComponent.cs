namespace SimpleBankSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialComponent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Account.Tab",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Balance = c.Decimal(nullable: false, precision: 4, scale: 2),
                        Currency = c.String(nullable: false),
                        UserTableId = c.Guid(nullable: false),
                        AccountHistoryId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("AccountHistory.Tab", t => t.AccountHistoryId, cascadeDelete: true)
                .ForeignKey("User.Tab", t => t.UserTableId, cascadeDelete: true)
                .Index(t => t.UserTableId)
                .Index(t => t.AccountHistoryId);
            
            CreateTable(
                "AccountHistory.Tab",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TransactionDate = c.DateTime(nullable: false),
                        TransactionName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "User.Tab",
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
                "Info.Tab",
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
            DropForeignKey("Account.Tab", "UserTableId", "User.Tab");
            DropForeignKey("Account.Tab", "AccountHistoryId", "AccountHistory.Tab");
            DropIndex("Account.Tab", new[] { "AccountHistoryId" });
            DropIndex("Account.Tab", new[] { "UserTableId" });
            DropTable("Info.Tab");
            DropTable("User.Tab");
            DropTable("AccountHistory.Tab");
            DropTable("Account.Tab");
        }
    }
}
