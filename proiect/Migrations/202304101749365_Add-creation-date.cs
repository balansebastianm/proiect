namespace proiect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addcreationdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "TwoFactorCreatedOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "TwoFactorCreatedOn");
        }
    }
}
