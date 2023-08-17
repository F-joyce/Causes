namespace Causes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeStructureSignaturesDbSet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Signatures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false),
                        CauseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Signatures");
        }
    }
}
