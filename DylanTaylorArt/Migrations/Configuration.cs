namespace DylanTaylorArt.Migrations
{
    using System.Data.Entity.Migrations;
    using DylanTaylorArt.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<GraphicDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DylanTaylorArt.Models.GraphicDbContext";
        }

        protected override void Seed(GraphicDbContext context)
        {
            SeedCollections(context);
            SeedGraphics(context);
        }

        private void SeedCollections(GraphicDbContext context)
        {
            context.Collections.AddOrUpdate(c => c.CollectionID,
                new Collection
                {
                    CollectionID = 1,
                    CollectionName = "The Drawn Blank Series",
                    Artist = Artists.Bob_Dylan,
                    Year = 2008
                },
                new Collection
                {
                    CollectionID = 2,
                    CollectionName = "Collection",
                    Artist = Artists.Bob_Dylan,
                    Year = 2009
                },
                new Collection
                {
                    CollectionID = 3,
                    CollectionName = "Collection",
                    Artist = Artists.Bob_Dylan,
                    Year = 2010
                }

                );
        }

        private static void SeedGraphics(GraphicDbContext context)
        {
            context.Graphics.AddOrUpdate(g => g.GraphicID,
                new Graphic
                {
                    GraphicID = 1,
                    CollectionID = 1,
                    Title = "Side Walk Cafe",

                    Format = GraphicFormats.Standard,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    ImageWidth = 16,
                    ImageHeight = 20.5,
                    PaperWidth = 22,
                    PaperHeight = 27.5,
                },
                new Graphic
                {
                    GraphicID = 2,
                    CollectionID = 1,
                    Title = "Sunday Afternoon",

                    Format = GraphicFormats.Standard,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    ImageWidth = 15,
                    ImageHeight = 21.5,

                    PaperWidth = 22,
                    PaperHeight = 27.5
                },
                new Graphic
                {
                    GraphicID = 3,
                    CollectionID = 1,
                    Title = "Vista from the Balcony",

                    Format = GraphicFormats.Standard,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    ImageWidth = 15.5,
                    ImageHeight = 21.5,

                    PaperWidth  = 22,
                    PaperHeight= 27.5
                },
                new Graphic
                {
                    GraphicID = 4,
                    CollectionID = 1,
                    Title = "Cassandra",

                    Format = GraphicFormats.Standard,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    ImageWidth = 16,
                    ImageHeight= 21.5,

                    PaperWidth = 22,
                    PaperHeight= 27.5
                });
        }
    }
}
