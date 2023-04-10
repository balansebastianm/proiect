namespace proiect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "TwoFactorCreatedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "TwoFactorCreatedOn", c => c.DateTime(nullable: false));
        }
    }
}
