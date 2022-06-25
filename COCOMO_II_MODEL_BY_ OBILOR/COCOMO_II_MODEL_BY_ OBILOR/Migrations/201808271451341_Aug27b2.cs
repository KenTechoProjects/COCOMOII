namespace COCOMO_II_MODEL_BY__OBILOR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Aug27b2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SoftwareTypeValues", "ConstantValue", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SoftwareTypeValues", "ConstantValue");
        }
    }
}
