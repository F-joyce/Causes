namespace Causes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedSignaturesToUseIdStrings : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "Cause_Id", "dbo.Causes");
            DropIndex("dbo.AspNetUsers", new[] { "Cause_Id" });
            DropColumn("dbo.AspNetUsers", "Cause_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Cause_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "Cause_Id");
            AddForeignKey("dbo.AspNetUsers", "Cause_Id", "dbo.Causes", "Id");
        }
    }
}
