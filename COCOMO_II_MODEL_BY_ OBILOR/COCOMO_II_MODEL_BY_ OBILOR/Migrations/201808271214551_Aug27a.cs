namespace COCOMO_II_MODEL_BY__OBILOR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Aug27a : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CostDriverRatings", "Name");
            DropColumn("dbo.ScaleDriverRatings", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ScaleDriverRatings", "Name", c => c.String());
            AddColumn("dbo.CostDriverRatings", "Name", c => c.String());
        }
    }
}
