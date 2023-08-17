namespace Causes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatorIdChngedToRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Causes", "CreatorId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Causes", "CreatorId", c => c.String());
        }
    }
}
