namespace Causes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedIsAngryProperty : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "IsAngry");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "IsAngry", c => c.Boolean(nullable: false));
        }
    }
}
