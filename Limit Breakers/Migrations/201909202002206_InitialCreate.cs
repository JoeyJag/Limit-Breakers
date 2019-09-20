namespace Limit_Breakers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registers",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Tokens = c.Int(nullable: false),
                        DisplayPicture = c.String(),
                        AccountStatus = c.String(),
                        PhoneNumber = c.String(),
                        UserType = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Registers");
        }
    }
}
