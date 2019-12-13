namespace KrzysztofJopekLab4Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Country = c.String(nullable: false),
                        Province = c.String(),
                        District = c.String(),
                        City = c.String(nullable: false),
                        Street = c.String(),
                        House_number = c.String(nullable: false),
                        Local_number = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Passengers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(),
                        Email = c.String(),
                        Phone = c.String(nullable: false),
                        AddressId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Place_number = c.String(nullable: false),
                        LuggageId = c.Int(nullable: false),
                        PassengerId = c.Int(nullable: false),
                        FlightId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Flights", t => t.FlightId, cascadeDelete: true)
                .ForeignKey("dbo.Luggages", t => t.LuggageId, cascadeDelete: true)
                .ForeignKey("dbo.Passengers", t => t.PassengerId, cascadeDelete: true)
                .Index(t => t.LuggageId)
                .Index(t => t.PassengerId)
                .Index(t => t.FlightId);
            
            CreateTable(
                "dbo.Flights",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Departure = c.String(nullable: false),
                        Arrival = c.String(nullable: false),
                        FlightDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Luggages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Package = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "PassengerId", "dbo.Passengers");
            DropForeignKey("dbo.Tickets", "LuggageId", "dbo.Luggages");
            DropForeignKey("dbo.Tickets", "FlightId", "dbo.Flights");
            DropForeignKey("dbo.Passengers", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Tickets", new[] { "FlightId" });
            DropIndex("dbo.Tickets", new[] { "PassengerId" });
            DropIndex("dbo.Tickets", new[] { "LuggageId" });
            DropIndex("dbo.Passengers", new[] { "AddressId" });
            DropTable("dbo.Luggages");
            DropTable("dbo.Flights");
            DropTable("dbo.Tickets");
            DropTable("dbo.Passengers");
            DropTable("dbo.Addresses");
        }
    }
}
