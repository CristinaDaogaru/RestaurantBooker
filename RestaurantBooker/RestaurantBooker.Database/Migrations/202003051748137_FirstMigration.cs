namespace RestaurantBooker.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(maxLength: 13),
                        UserAuthenticationId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserAuthentications", t => t.UserAuthenticationId, cascadeDelete: true)
                .Index(t => t.UserAuthenticationId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PhoneContact = c.String(nullable: false, maxLength: 13),
                        Observation = c.String(maxLength: 500),
                        State = c.Int(nullable: false),
                        ClientId = c.Guid(nullable: false),
                        RestaurantId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Restaurants", t => t.RestaurantId)
                .ForeignKey("dbo.Clients", t => t.ClientId)
                .Index(t => t.ClientId)
                .Index(t => t.RestaurantId);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(nullable: false, maxLength: 13),
                        CuisineType = c.Int(nullable: false),
                        UserAuthenticationId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserAuthentications", t => t.UserAuthenticationId, cascadeDelete: true)
                .Index(t => t.UserAuthenticationId);
            
            CreateTable(
                "dbo.UserAuthentications",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "UserAuthenticationId", "dbo.UserAuthentications");
            DropForeignKey("dbo.Reservations", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Restaurants", "UserAuthenticationId", "dbo.UserAuthentications");
            DropForeignKey("dbo.Reservations", "RestaurantId", "dbo.Restaurants");
            DropIndex("dbo.Restaurants", new[] { "UserAuthenticationId" });
            DropIndex("dbo.Reservations", new[] { "RestaurantId" });
            DropIndex("dbo.Reservations", new[] { "ClientId" });
            DropIndex("dbo.Clients", new[] { "UserAuthenticationId" });
            DropTable("dbo.UserAuthentications");
            DropTable("dbo.Restaurants");
            DropTable("dbo.Reservations");
            DropTable("dbo.Clients");
        }
    }
}
