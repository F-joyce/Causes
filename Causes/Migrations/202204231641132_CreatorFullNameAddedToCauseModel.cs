namespace Causes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatorFullNameAddedToCauseModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Causes", "CreatorName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Causes", "CreatorName");
        }
    }
}
