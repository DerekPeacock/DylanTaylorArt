namespace DylanTaylorArt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyPortfolio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Graphics", "Portfolio", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Graphics", "Portfolio");
        }
    }
}
