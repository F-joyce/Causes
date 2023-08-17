namespace Causes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCollectionSignatures : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Signatures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserSignature = c.String(),
                        Cause_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Causes", t => t.Cause_Id)
                .Index(t => t.Cause_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Signatures", "Cause_Id", "dbo.Causes");
            DropIndex("dbo.Signatures", new[] { "Cause_Id" });
            DropTable("dbo.Signatures");
        }
    }
}
