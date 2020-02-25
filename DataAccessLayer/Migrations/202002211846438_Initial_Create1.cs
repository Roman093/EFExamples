namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Create1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gemstones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        color = c.String(),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        GemstoneTypeId = c.Int(nullable: false),
                        Jevellery_Id = c.Int(),
                        Manufactory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GemstoneTypes", t => t.GemstoneTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Jevelleries", t => t.Jevellery_Id)
                .ForeignKey("dbo.Manufactories", t => t.Manufactory_Id)
                .Index(t => t.GemstoneTypeId)
                .Index(t => t.Jevellery_Id)
                .Index(t => t.Manufactory_Id);
            
            CreateTable(
                "dbo.GemstoneTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jevelleries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        ManufactoryId = c.Int(nullable: false),
                        JavelleryTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufactories", t => t.ManufactoryId, cascadeDelete: true)
                .Index(t => t.ManufactoryId);
            
            CreateTable(
                "dbo.Manufactories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CountryId = c.Int(nullable: false),
                        LicenseNumber = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jevelleries", "ManufactoryId", "dbo.Manufactories");
            DropForeignKey("dbo.Gemstones", "Manufactory_Id", "dbo.Manufactories");
            DropForeignKey("dbo.Gemstones", "Jevellery_Id", "dbo.Jevelleries");
            DropForeignKey("dbo.Gemstones", "GemstoneTypeId", "dbo.GemstoneTypes");
            DropIndex("dbo.Jevelleries", new[] { "ManufactoryId" });
            DropIndex("dbo.Gemstones", new[] { "Manufactory_Id" });
            DropIndex("dbo.Gemstones", new[] { "Jevellery_Id" });
            DropIndex("dbo.Gemstones", new[] { "GemstoneTypeId" });
            DropTable("dbo.Manufactories");
            DropTable("dbo.Jevelleries");
            DropTable("dbo.GemstoneTypes");
            DropTable("dbo.Gemstones");
        }
    }
}
