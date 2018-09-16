namespace DylanTaylorArt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GraphicCollections",
                c => new
                    {
                        GraphicCollectionId = c.Int(nullable: false, identity: true),
                        CollectionName = c.String(nullable: false, maxLength: 60),
                        Artist = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        Description = c.String(maxLength: 500),
                        ImagePath = c.String(maxLength: 120),
                    })
                .PrimaryKey(t => t.GraphicCollectionId);
            
            CreateTable(
                "dbo.Graphics",
                c => new
                    {
                        GraphicID = c.Int(nullable: false, identity: true),
                        CollectionId = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 60),
                        Description = c.String(maxLength: 500),
                        LargeImagePath = c.String(maxLength: 100),
                        SmallImagePath = c.String(maxLength: 100),
                        Format = c.Int(nullable: false),
                        DateReleased = c.DateTime(nullable: false),
                        Paper = c.String(maxLength: 60),
                        Aspect = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        FramedWith = c.Int(nullable: false),
                        DisplayInCarousel = c.Boolean(nullable: false),
                        DisplayOnHomePage = c.Boolean(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Collection_GraphicCollectionId = c.Int(),
                    })
                .PrimaryKey(t => t.GraphicID)
                .ForeignKey("dbo.GraphicCollections", t => t.Collection_GraphicCollectionId)
                .Index(t => t.Collection_GraphicCollectionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Graphics", "Collection_GraphicCollectionId", "dbo.GraphicCollections");
            DropIndex("dbo.Graphics", new[] { "Collection_GraphicCollectionId" });
            DropTable("dbo.Graphics");
            DropTable("dbo.GraphicCollections");
        }
    }
}
