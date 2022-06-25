namespace COCOMO_II_MODEL_BY__OBILOR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Aug27 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CostDriverRatings", "Name", c => c.String());
            AddColumn("dbo.CostDriverRatings", "Rating", c => c.String());
            AddColumn("dbo.CostDriverRatings", "EM", c => c.Double(nullable: false));
            AddColumn("dbo.ScaleDriverRatings", "Value", c => c.Double(nullable: false));
            AddColumn("dbo.ScaleDriverRatings", "Rating", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ScaleDriverRatings", "Rating");
            DropColumn("dbo.ScaleDriverRatings", "Value");
            DropColumn("dbo.CostDriverRatings", "EM");
            DropColumn("dbo.CostDriverRatings", "Rating");
            DropColumn("dbo.CostDriverRatings", "Name");
        }
    }
}
