namespace COCOMO_II_MODEL_BY__OBILOR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Aug27b : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SoftwareTypes",
                c => new
                    {
                        SoftwareTypeID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SoftwareTypeID);
            
            CreateTable(
                "dbo.SoftwareTypeValues",
                c => new
                    {
                        SoftwareTypeValueID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SoftwareType_SoftwareTypeID = c.Int(),
                    })
                .PrimaryKey(t => t.SoftwareTypeValueID)
                .ForeignKey("dbo.SoftwareTypes", t => t.SoftwareType_SoftwareTypeID)
                .Index(t => t.SoftwareType_SoftwareTypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SoftwareTypeValues", "SoftwareType_SoftwareTypeID", "dbo.SoftwareTypes");
            DropIndex("dbo.SoftwareTypeValues", new[] { "SoftwareType_SoftwareTypeID" });
            DropTable("dbo.SoftwareTypeValues");
            DropTable("dbo.SoftwareTypes");
        }
    }
}
