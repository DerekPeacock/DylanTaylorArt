namespace DylanTaylorArt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeFK : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Collections",
                c => new
                    {
                        CollectionID = c.Int(nullable: false, identity: true),
                        CollectionName = c.String(nullable: false, maxLength: 60),
                        Artist = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        Description = c.String(maxLength: 500),
                        ImagePath = c.String(maxLength: 120),
                    })
                .PrimaryKey(t => t.CollectionID);
            
            DropTable("dbo.GraphicCollections");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.GraphicCollections",
                c => new
                    {
                        GraphicCollectionID = c.Int(nullable: false, identity: true),
                        CollectionName = c.String(nullable: false, maxLength: 60),
                        Artist = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        Description = c.String(maxLength: 500),
                        ImagePath = c.String(maxLength: 120),
                    })
                .PrimaryKey(t => t.GraphicCollectionID);
            
            DropTable("dbo.Collections");
        }
    }
}
