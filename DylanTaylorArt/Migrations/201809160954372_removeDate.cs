namespace DylanTaylorArt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeDate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Graphics", "DateReleased");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Graphics", "DateReleased", c => c.DateTime(nullable: false));
        }
    }
}
