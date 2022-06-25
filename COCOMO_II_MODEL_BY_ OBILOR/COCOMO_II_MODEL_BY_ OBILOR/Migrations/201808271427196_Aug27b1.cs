namespace COCOMO_II_MODEL_BY__OBILOR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Aug27b1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SoftwareTypeValues", "SoftwareType_SoftwareTypeID", "dbo.SoftwareTypes");
            DropIndex("dbo.SoftwareTypeValues", new[] { "SoftwareType_SoftwareTypeID" });
            RenameColumn(table: "dbo.SoftwareTypeValues", name: "SoftwareType_SoftwareTypeID", newName: "SoftwareTypeID");
            AlterColumn("dbo.SoftwareTypeValues", "SoftwareTypeID", c => c.Int(nullable: false));
            CreateIndex("dbo.SoftwareTypeValues", "SoftwareTypeID");
            AddForeignKey("dbo.SoftwareTypeValues", "SoftwareTypeID", "dbo.SoftwareTypes", "SoftwareTypeID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SoftwareTypeValues", "SoftwareTypeID", "dbo.SoftwareTypes");
            DropIndex("dbo.SoftwareTypeValues", new[] { "SoftwareTypeID" });
            AlterColumn("dbo.SoftwareTypeValues", "SoftwareTypeID", c => c.Int());
            RenameColumn(table: "dbo.SoftwareTypeValues", name: "SoftwareTypeID", newName: "SoftwareType_SoftwareTypeID");
            CreateIndex("dbo.SoftwareTypeValues", "SoftwareType_SoftwareTypeID");
            AddForeignKey("dbo.SoftwareTypeValues", "SoftwareType_SoftwareTypeID", "dbo.SoftwareTypes", "SoftwareTypeID");
        }
    }
}
