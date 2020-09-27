namespace SimpleBankSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialComponent1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Account.Tab", "Balance", c => c.Decimal(nullable: false, precision: 30, scale: 20));
        }
        
        public override void Down()
        {
            AlterColumn("Account.Tab", "Balance", c => c.Decimal(nullable: false, precision: 4, scale: 2));
        }
    }
}
