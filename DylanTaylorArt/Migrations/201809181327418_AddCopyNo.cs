namespace DylanTaylorArt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCopyNo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Graphics", "CopyNo", c => c.Int(nullable: false));
            DropColumn("dbo.Graphics", "DisplayInCarousel");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Graphics", "DisplayInCarousel", c => c.Boolean(nullable: false));
            DropColumn("dbo.Graphics", "CopyNo");
        }
    }
}
