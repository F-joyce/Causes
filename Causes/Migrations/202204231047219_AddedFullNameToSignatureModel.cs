namespace Causes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFullNameToSignatureModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Signatures", "UserFullName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Signatures", "UserFullName");
        }
    }
}
