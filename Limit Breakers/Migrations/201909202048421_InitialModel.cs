namespace Limit_Breakers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Registers", "DisplayPicture");
            DropColumn("dbo.Registers", "AccountStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Registers", "AccountStatus", c => c.String());
            AddColumn("dbo.Registers", "DisplayPicture", c => c.String());
        }
    }
}
