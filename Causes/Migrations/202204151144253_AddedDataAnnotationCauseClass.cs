namespace Causes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDataAnnotationCauseClass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Causes", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Causes", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Causes", "Description", c => c.String());
            AlterColumn("dbo.Causes", "Title", c => c.String());
        }
    }
}
