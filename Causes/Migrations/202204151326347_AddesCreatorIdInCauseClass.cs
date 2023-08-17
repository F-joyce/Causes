namespace Causes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddesCreatorIdInCauseClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Causes", "CreatorId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Causes", "CreatorId");
        }
    }
}
