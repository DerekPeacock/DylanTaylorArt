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
            context.Collections.AddOrUpdate(c => c.CollectionName,
                new Collection
                {
                    CollectionID = 1,
                    CollectionName = "The Drawn Blank Series 2008",
                    Artist = Artists.Bob_Dylan,
                    Year = 2008,
                    ImagePath = "DB2008"
                },
                new Collection
                {
                    CollectionID = 2,
                    CollectionName = "The Drawn Blank Series 2009",
                    Artist = Artists.Bob_Dylan,
                    Year = 2009,
                    ImagePath = "DB2009"
                },
                new Collection
                {
                    CollectionID = 3,
                    CollectionName = "The Drawn Blank Series 2010",
                    Artist = Artists.Bob_Dylan,
                    Year = 2010,
                    ImagePath = "DB2010"
                },
                new Collection
                {
                    CollectionID = 4,
                    CollectionName = "The Drawn Blank Series 2011",
                    Artist = Artists.Bob_Dylan,
                    Year = 2011,
                    ImagePath = "DB2011"
                },
                new Collection
                {
                    CollectionID = 5,
                    CollectionName = "The Drawn Blank Series 2012",
                    Artist = Artists.Bob_Dylan,
                    Year = 2012,
                    ImagePath = "DB2012"
                },
                new Collection
                {
                    CollectionID = 6,
                    CollectionName = "The Drawn Blank Series 2013",
                    Artist = Artists.Bob_Dylan,
                    Year = 2013,
                    ImagePath = "DB2013"
                },
                new Collection
                {
                    CollectionID = 7,
                    CollectionName = "The Drawn Blank Series 2014",
                    Artist = Artists.Bob_Dylan,
                    Year = 2014,
                    ImagePath = "DB2014"
                },
                new Collection
                {
                    CollectionID = 8,
                    CollectionName = "The Drawn Blank Series 2016",
                    Artist = Artists.Bob_Dylan,
                    Year = 2016,
                    ImagePath = "DB2016"
                },
                new Collection
                {
                    CollectionID = 9,
                    CollectionName = "The Drawn Blank Series - Train Tracks",
                    Artist = Artists.Bob_Dylan,
                    Year = 2012,
                    ImagePath = "DB2012TT"
                },
                new Collection
                {
                    CollectionID = 10,
                    CollectionName = "The Brazil Series",
                    Artist = Artists.Bob_Dylan,
                    Year = 2015,
                    ImagePath = "BZ2015"
                } );
        }

        private static void SeedGraphics(GraphicDbContext context)
        {
            context.Graphics.AddOrUpdate(g => g.Title,
                new Graphic
                {
                    GraphicID = 1,
                    CollectionID = 1,
                    CopyNo = 99,
                    Title = "Side Walk Cafe",
                    SmallImagePath = "SideWalkCafe",

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
                    Title = "Lakeside Cabin",
                    SmallImagePath = "LakesideCabin",

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
                    CopyNo = 99,
                    Title = "Dads Restaurant",
                    SmallImagePath = "DadsRestaurant",

                    Format = GraphicFormats.Standard,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    ImageWidth = 16,
                    ImageHeight = 21.5,

                    PaperWidth = 22,
                    PaperHeight = 27.5,

                    Price = 2450m
                },
                new Graphic
                {
                    GraphicID = 4,
                    CollectionID = 1,
                    CopyNo = 229,
                    Title = "Amagansett",
                    SmallImagePath = "Amagansett",

                    Format = GraphicFormats.Medium,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    ImageWidth = 22,
                    ImageHeight = 30,

                    PaperWidth = 28,
                    PaperHeight = 36,

                    Price = 2800m
                },
                new Graphic
                {
                    GraphicID = 5,
                    CollectionID = 1,
                    CopyNo = 234,
                    Title = "Truck",
                    SmallImagePath = "Truck",

                    Format = GraphicFormats.Medium,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    ImageWidth = 22,
                    ImageHeight = 29.5,

                    PaperWidth = 28,
                    PaperHeight = 36,

                    Price = 4250m
                },
                new Graphic
                {
                    GraphicID = 6,
                    CollectionID = 1,
                    CopyNo = 52,
                    Title = "Man on a Bridge",
                    SmallImagePath = "ManBridge",

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
                    SmallImagePath = "WomenInPub",

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
                    SmallImagePath = "WomenInPub4",

                    Format = GraphicFormats.Standard,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    Portfolio = Portfolios.Setof_4,

                    ImageWidth = 16,
                    ImageHeight = 21,

                    PaperWidth = 22,
                    PaperHeight = 27.5,

                    Price = 9500m,
                    BDA_Price = 20000m
                },
                new Graphic
                {
                    GraphicID = 9,
                    CollectionID = 1,
                    CopyNo = 52,
                    Title = "Women in Red Lion Pub - Pink Dress",
                    SmallImagePath = "WomenInPubPink",

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
                    SmallImagePath = "ManBridgeBrown",

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
                    SmallImagePath = "TrainTracks",

                    Format = GraphicFormats.Standard,
                    Portfolio = Portfolios.Setof_4,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    ImageWidth = 16,
                    ImageHeight = 21.5,

                    PaperWidth = 22,
                    PaperHeight = 27.5,

                    Price = 18000m,
                    BDA_Price = 40000m
                },
                new Graphic
                {
                    GraphicID = 12,
                    CollectionID = 1,
                    CopyNo = 99,
                    Title = "Train Tracks - White",
                    SmallImagePath = "TrainTracksWhite",

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
                    CopyNo = 81,
                    Title = "Train Tracks - Orange",
                    SmallImagePath = "TrainTracksOrange",

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
                },

                new Graphic
                {
                    GraphicID = 14,
                    CollectionID = 2,
                    CopyNo = 0,
                    Title = "Truck Stop",
                    SmallImagePath = "TruckStop",

                    Format = GraphicFormats.Standard,
                    Portfolio = Portfolios.None,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    FramedWith = FrameMaterial.Glass,

                    DisplayOnHomePage = false,

                    ImageWidth = 15.25,
                    ImageHeight = 21.5,

                    PaperWidth = 22,
                    PaperHeight = 27.5,

                    Price = 2150m
                },
                new Graphic
                {
                    GraphicID = 15,
                    CollectionID = 2,
                    CopyNo = 0,
                    Title = "Three Chairs",
                    SmallImagePath = "ThreeChairs",

                    Format = GraphicFormats.Standard,
                    Portfolio = Portfolios.None,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    FramedWith = FrameMaterial.Glass,

                    DisplayOnHomePage = true,

                    ImageWidth = 15.75,
                    ImageHeight = 21.25,

                    PaperWidth = 22,
                    PaperHeight = 27.5,

                    Price = 2600m
                },
               new Graphic
               {
                   GraphicID = 16,
                   CollectionID = 2,
                   CopyNo = 0,
                   Title = "Bicycle",
                   SmallImagePath = "Bicycle",

                   Format = GraphicFormats.Standard,
                   Portfolio = Portfolios.None,
                   Aspect = PictureAspects.Portrait,
                   Status = GraphicStatus.ForSale,

                   FramedWith = FrameMaterial.Glass,

                   DisplayOnHomePage = true,

                   ImageWidth = 15.75,
                   ImageHeight = 21.5,

                   PaperWidth = 22,
                   PaperHeight = 27.5,

                   Price = 2850m
               },
                new Graphic
                {
                    GraphicID = 17,
                    CollectionID = 2,
                    CopyNo = 0,
                    Title = "Sunflowers",
                    SmallImagePath = "Sunflowers",

                    Format = GraphicFormats.Standard,
                    Portfolio = Portfolios.None,
                    Aspect = PictureAspects.Portrait,
                    Status = GraphicStatus.ForSale,

                    FramedWith = FrameMaterial.Glass,

                    DisplayOnHomePage = true,

                    ImageWidth = 15.75,
                    ImageHeight = 21.5,

                    PaperWidth = 22,
                    PaperHeight = 27.5,

                    Price = 2850m
                },
               new Graphic
               {
                   GraphicID = 18,
                   CollectionID = 2,
                   CopyNo = 0,
                   Title = "Rose on a Hillside",
                   SmallImagePath = "RoseHill",

                   Format = GraphicFormats.Standard,
                   Portfolio = Portfolios.None,
                   Aspect = PictureAspects.Portrait,
                   Status = GraphicStatus.ForSale,

                   FramedWith = FrameMaterial.Glass,

                   DisplayOnHomePage = true,

                   ImageWidth = 15.75,
                   ImageHeight = 20.75,

                   PaperWidth = 22,
                   PaperHeight = 27.5,

                   Price = 2850m
               });
        }
    }
}
