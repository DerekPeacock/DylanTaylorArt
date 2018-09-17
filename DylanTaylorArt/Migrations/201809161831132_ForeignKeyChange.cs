namespace DylanTaylorArt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeyChange : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Graphics", "Collection_GraphicCollectionID", "dbo.GraphicCollections");
            DropIndex("dbo.Graphics", new[] { "Collection_GraphicCollectionID" });
            DropColumn("dbo.Graphics", "CollectionId");
            RenameColumn(table: "dbo.Graphics", name: "Collection_GraphicCollectionID", newName: "GraphicCollectionID");
            AlterColumn("dbo.Graphics", "CollectionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Graphics", "CollectionID");
            AddForeignKey("dbo.Graphics", "CollectionID", "dbo.GraphicCollections", "GraphicCollectionID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Graphics", "CollectionID", "dbo.GraphicCollections");
            DropIndex("dbo.Graphics", new[] { "CollectionID" });
            AlterColumn("dbo.Graphics", "CollectionId", c => c.Int());
            RenameColumn(table: "dbo.Graphics", name: "CollectionID", newName: "GraphicCollectionID");
            AddColumn("dbo.Graphics", "CollectionID", c => c.Int(nullable: false));
            CreateIndex("dbo.Graphics", "Collection_GraphicCollectionID");
            AddForeignKey("dbo.Graphics", "Collection_GraphicCollectionID", "dbo.GraphicCollections", "GraphicCollectionID");
        }
    }
}
