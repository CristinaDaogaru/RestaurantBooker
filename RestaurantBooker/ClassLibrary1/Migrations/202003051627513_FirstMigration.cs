namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Clients", "Phone", c => c.String(maxLength: 13));
            AlterColumn("dbo.Reservations", "PhoneContact", c => c.String(nullable: false, maxLength: 13));
            AlterColumn("dbo.Reservations", "Observation", c => c.String(maxLength: 500));
            AlterColumn("dbo.Restaurants", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Restaurants", "Address", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Restaurants", "Phone", c => c.String(nullable: false, maxLength: 13));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Restaurants", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Restaurants", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Restaurants", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Reservations", "Observation", c => c.String());
            AlterColumn("dbo.Reservations", "PhoneContact", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "Phone", c => c.String());
            AlterColumn("dbo.Clients", "Name", c => c.String(nullable: false));
        }
    }
}
