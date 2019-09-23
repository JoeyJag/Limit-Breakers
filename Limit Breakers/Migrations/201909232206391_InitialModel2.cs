namespace Limit_Breakers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Registers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Registers", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.Registers", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Registers", "UserType", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Registers", "UserType", c => c.String());
            AlterColumn("dbo.Registers", "Password", c => c.String());
            AlterColumn("dbo.Registers", "Username", c => c.String());
            AlterColumn("dbo.Registers", "Email", c => c.String());
        }
    }
}
