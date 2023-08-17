namespace Causes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCauseTypeNameToCauseClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Causes", "CauseTypeName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Causes", "CauseTypeName");
        }
    }
}
