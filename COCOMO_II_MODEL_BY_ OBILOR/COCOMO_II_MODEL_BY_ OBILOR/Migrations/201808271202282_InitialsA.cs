namespace COCOMO_II_MODEL_BY__OBILOR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialsA : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CostDrivers",
                c => new
                    {
                        CostDriverID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CostDriverID);
            
            CreateTable(
                "dbo.CostDriverRatings",
                c => new
                    {
                        CostDriverRatingID = c.Int(nullable: false, identity: true),
                        CostDriverID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CostDriverRatingID)
                .ForeignKey("dbo.CostDrivers", t => t.CostDriverID, cascadeDelete: true)
                .Index(t => t.CostDriverID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectID = c.String(nullable: false, maxLength: 128),
                        ProjectName = c.String(),
                        LOC = c.Long(nullable: false),
                        E = c.Double(nullable: false),
                        Effort = c.Double(nullable: false),
                        EAF = c.Double(nullable: false),
                        PM = c.Double(nullable: false),
                        Duration = c.Double(nullable: false),
                        AverageStaffing = c.Double(nullable: false),
                        Cost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectID);
            
            CreateTable(
                "dbo.ScaleDrivers",
                c => new
                    {
                        ScaleDriverID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ScaleDriverID);
            
            CreateTable(
                "dbo.ScaleDriverRatings",
                c => new
                    {
                        ScaleDriverRatingID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ScaleDriverID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ScaleDriverRatingID)
                .ForeignKey("dbo.ScaleDrivers", t => t.ScaleDriverID, cascadeDelete: true)
                .Index(t => t.ScaleDriverID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ScaleDriverRatings", "ScaleDriverID", "dbo.ScaleDrivers");
            DropForeignKey("dbo.CostDriverRatings", "CostDriverID", "dbo.CostDrivers");
            DropIndex("dbo.ScaleDriverRatings", new[] { "ScaleDriverID" });
            DropIndex("dbo.CostDriverRatings", new[] { "CostDriverID" });
            DropTable("dbo.ScaleDriverRatings");
            DropTable("dbo.ScaleDrivers");
            DropTable("dbo.Projects");
            DropTable("dbo.CostDriverRatings");
            DropTable("dbo.CostDrivers");
        }
    }
}
