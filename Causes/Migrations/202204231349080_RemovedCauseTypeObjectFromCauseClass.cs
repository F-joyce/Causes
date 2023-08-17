namespace Causes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedCauseTypeObjectFromCauseClass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Causes", "CauseTypeId", "dbo.CauseTypes");
            DropIndex("dbo.Causes", new[] { "CauseTypeId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Causes", "CauseTypeId");
            AddForeignKey("dbo.Causes", "CauseTypeId", "dbo.CauseTypes", "Id", cascadeDelete: true);
        }
    }
}
