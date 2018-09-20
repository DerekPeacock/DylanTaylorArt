namespace DylanTaylorArt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPrices : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Graphics", "BDA_Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Graphics", "CastlePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Graphics", "CanvasPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Graphics", "CanvasPrice");
            DropColumn("dbo.Graphics", "CastlePrice");
            DropColumn("dbo.Graphics", "BDA_Price");
        }
    }
}
