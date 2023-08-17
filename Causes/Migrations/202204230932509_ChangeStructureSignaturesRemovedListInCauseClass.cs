namespace Causes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeStructureSignaturesRemovedListInCauseClass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Signatures", "Cause_Id", "dbo.Causes");
            DropIndex("dbo.Signatures", new[] { "Cause_Id" });
            DropTable("dbo.Signatures");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Signatures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserSignature = c.String(),
                        Cause_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Signatures", "Cause_Id");
            AddForeignKey("dbo.Signatures", "Cause_Id", "dbo.Causes", "Id");
        }
    }
}
