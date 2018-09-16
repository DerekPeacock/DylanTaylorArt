namespace DylanTaylorArt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeID : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Graphics", new[] { "Collection_GraphicCollectionId" });
            CreateIndex("dbo.Graphics", "Collection_GraphicCollectionID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Graphics", new[] { "Collection_GraphicCollectionID" });
            CreateIndex("dbo.Graphics", "Collection_GraphicCollectionId");
        }
    }
}
