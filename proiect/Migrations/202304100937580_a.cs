namespace proiect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "TwoFactorKey", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "TwoFactorKey", c => c.String(nullable: false));
        }
    }
}
