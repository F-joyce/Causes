namespace Causes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUsersProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FullName", c => c.String());
            AddColumn("dbo.AspNetUsers", "IsAngry", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "IsAngry");
            DropColumn("dbo.AspNetUsers", "FullName");
        }
    }
}
