namespace DylanTaylorArt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReplaceSize : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Graphics", "ImageWidth", c => c.Double(nullable: false));
            AddColumn("dbo.Graphics", "ImageHeight", c => c.Double(nullable: false));
            AddColumn("dbo.Graphics", "PaperWidth", c => c.Double(nullable: false));
            AddColumn("dbo.Graphics", "PaperHeight", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Graphics", "PaperHeight");
            DropColumn("dbo.Graphics", "PaperWidth");
            DropColumn("dbo.Graphics", "ImageHeight");
            DropColumn("dbo.Graphics", "ImageWidth");
        }
    }
}
