namespace PhoneApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        ManufactureID = c.Int(nullable: false, identity: true),
                        ManufacturerName = c.String(),
                        URL = c.String(),
                        DateReleased = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ManufactureID);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        PhoneId = c.Int(nullable: false, identity: true),
                        PhoneName = c.String(),
                        DateReleased = c.DateTime(nullable: false),
                        ManufactureID = c.Int(nullable: false),
                        MSRP = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PhoneId)
                .ForeignKey("dbo.Manufacturers", t => t.ManufactureID, cascadeDelete: true)
                .Index(t => t.ManufactureID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "ManufactureID", "dbo.Manufacturers");
            DropIndex("dbo.Phones", new[] { "ManufactureID" });
            DropTable("dbo.Phones");
            DropTable("dbo.Manufacturers");
        }
    }
}
