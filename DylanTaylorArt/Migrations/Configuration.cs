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
                    CollectionName = "The Drawn Blank Series",
                    Artist = Artists.Bob_Dylan,
                    Year = 2009
                },
                new Collection
                {
                    CollectionID = 3,
                    CollectionName = "The Drawn Blank Series",
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
                    CopyNo = 99,
                    Title = "Side Walk Cafe",
                    SmallImagePath = "2008_SideWalkCafe",

                    Format = GraphicFormats.Standard,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    ImageWidth = 16,
                    ImageHeight = 20.5,
                    PaperWidth = 22,
                    PaperHeight = 27.5,

                    Price = 2350m
                },
                new Graphic
                {
                    GraphicID = 2,
                    CollectionID = 1,
                    CopyNo = 254,
                    Title = "Lakeside Cafe",
                    SmallImagePath = "2008_LakesideCafe",

                    Format = GraphicFormats.Standard,
                    Aspect = PictureAspects.Landscape,
                    Status = GraphicStatus.ForSale,

                    ImageWidth = 16,
                    ImageHeight = 21,

                    PaperWidth = 22,
                    PaperHeight = 27.5,

                    Price = 1750m
                },
                new Graphic
                {
                    GraphicID = 3,
                    CollectionID = 1,
                    Title = "Dads Restaurant",
                    SmallImagePath = "2008_DadsRestaurant",

                    Format = GraphicFormats.Standard,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    ImageWidth = 16,
                    ImageHeight = 21.5,

                    PaperWidth  = 22,
                    PaperHeight= 27.5,

                    Price = 2450m
                },
                new Graphic
                {
                    GraphicID = 4,
                    CollectionID = 1,
                    CopyNo = 229,
                    Title = "Amagansett",
                    SmallImagePath = "2008_Amagansett",

                    Format = GraphicFormats.Medium,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    ImageWidth = 22,
                    ImageHeight= 30,

                    PaperWidth = 28,
                    PaperHeight= 36,

                    Price = 2800m
                },
                new Graphic
                {
                    GraphicID = 5,
                    CollectionID = 1,
                    CopyNo = 0,
                    Title = "Truck",
                    SmallImagePath = "2008_Truck",

                    Format = GraphicFormats.Medium,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    ImageWidth = 22,
                    ImageHeight= 29.5,

                    PaperWidth = 28,
                    PaperHeight= 36,

                    Price = 4250m
                },
                new Graphic
                {
                    GraphicID = 6,
                    CollectionID = 1,
                    CopyNo = 52,
                    Title = "Man on a Bridge",
                    SmallImagePath = "2008_ManBridge",

                    Format = GraphicFormats.Medium,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    ImageWidth = 22,
                    ImageHeight = 30,

                    PaperWidth = 28,
                    PaperHeight = 36,

                    Price = 9750m
                },
                new Graphic
                {
                    GraphicID = 7,
                    CollectionID = 1,
                    CopyNo = 52,
                    Title = "Women in Red Lion Pub",
                    SmallImagePath = "2008_WomenInPub",

                    Format = GraphicFormats.Medium,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    ImageWidth = 22,
                    ImageHeight = 29,

                    PaperWidth = 28,
                    PaperHeight = 36,

                    Price = 7750m
                },

                new Graphic
                {
                    GraphicID = 8,
                    CollectionID = 1,
                    CopyNo = 52,
                    Title = "Women in Red Lion Pub - Set of 4",
                    SmallImagePath = "2008_WomenInPub4",

                    Format = GraphicFormats.Standard,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    Portfolio = Portfolios.Setof_4,

                    ImageWidth = 16,
                    ImageHeight = 21,

                    PaperWidth = 22,
                    PaperHeight = 27.5,

                    Price = 9500m
                },
                new Graphic
                {
                    GraphicID = 9,
                    CollectionID = 1,
                    CopyNo = 52,
                    Title = "Women in Red Lion Pub - Pink Dress",
                    SmallImagePath = "2008_WomenInPubPink",

                    Format = GraphicFormats.Standard,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    Portfolio = Portfolios.Parts_1of4,

                    ImageWidth = 16,
                    ImageHeight = 21,

                    PaperWidth = 22,
                    PaperHeight = 27.5,

                    Price = 7750m
                },
                new Graphic
                {
                    GraphicID = 10,
                    CollectionID = 1,
                    CopyNo = 99,
                    Title = "Man on a Bridge - Brown Coat",
                    SmallImagePath = "2008_ManBridgeBrown",

                    Format = GraphicFormats.Standard,
                    Portfolio = Portfolios.Parts_1of4,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    ImageWidth = 16,
                    ImageHeight = 21.5,

                    PaperWidth = 28,
                    PaperHeight = 36,

                    Price = 2400m
                },

                new Graphic
                {
                    GraphicID = 11,
                    CollectionID = 1,
                    CopyNo = 99,
                    Title = "Train Tracks - Set of 4",
                    SmallImagePath = "2008_TrainTracks",

                    Format = GraphicFormats.Standard,
                    Portfolio = Portfolios.Setof_4,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    ImageWidth = 16,
                    ImageHeight = 21.5,

                    PaperWidth = 22,
                    PaperHeight = 27.5,

                    Price = 18000m
                },
                new Graphic
                {
                    GraphicID = 12,
                    CollectionID = 1,
                    CopyNo = 99,
                    Title = "Train Tracks - White",
                    SmallImagePath = "2008_TrainTracksWhite",

                    Format = GraphicFormats.Standard,
                    Portfolio = Portfolios.Parts_1of4,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    ImageWidth = 16,
                    ImageHeight = 21.5,

                    PaperWidth = 22,
                    PaperHeight = 27.5,

                    Price = 4800m
                },
                new Graphic
                {
                    GraphicID = 13,
                    CollectionID = 1,
                    CopyNo = 99,
                    Title = "Train Tracks - Orange",
                    SmallImagePath = "2008_TrainTracksOrange",

                    Format = GraphicFormats.Standard,
                    Portfolio = Portfolios.Parts_1of4,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    FramedWith = FrameMaterial.None,

                    ImageWidth = 16,
                    ImageHeight = 21.5,

                    PaperWidth = 22,
                    PaperHeight = 27.5,

                    Price = 7000m
                }
                );
        }
    }
}
