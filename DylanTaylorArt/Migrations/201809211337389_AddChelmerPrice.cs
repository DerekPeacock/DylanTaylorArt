namespace DylanTaylorArt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddChelmerPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Graphics", "CFA_Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Graphics", "CFA_Price");
        }
    }
}
