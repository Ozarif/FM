namespace FM.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewModifications : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Citizens", "Religion", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Citizens", "ReligionSect", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.FamilyMemberInfoes", "Sex", c => c.Int(nullable: false));
            AlterColumn("dbo.ServiceInfoes", "ContactNumber", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ServiceInfoes", "ContactNumber", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.FamilyMemberInfoes", "Sex", c => c.String(nullable: false));
            AlterColumn("dbo.Citizens", "ReligionSect", c => c.String(nullable: false));
            AlterColumn("dbo.Citizens", "Religion", c => c.String(nullable: false));
        }
    }
}
