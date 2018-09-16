using System;
using System.ComponentModel.DataAnnotations;


namespace DylanTaylorArt.Models
{
    public class Graphic
    {
        public const double INCHES_TO_CENTIMETERS = 2.54;

        public int GraphicID { get; set; }

        [Required]
        public int CollectionId { get; set; }

        [Required, StringLength(60)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(100)]
        public string LargeImagePath { get; set; }

        [StringLength(100)]
        public string SmallImagePath { get; set; }

        public GraphicFormats Format { get; set; }

        [StringLength(60)]
        public string Paper { get; set; }

        public PictureAspects Aspect { get; set; }

        public double ImageWidth { get; set; }

        public double ImageHeight { get; set; }

        public double PaperWidth { get; set; }

        public double PaperHeight { get; set; }

        public GraphicStatus Status { get; set; }

        public FrameMaterial FramedWith { get; set; }

        public bool DisplayInCarousel { get; set; }

        public bool DisplayOnHomePage { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public virtual GraphicCollection Collection { get; set; }

        public Graphic()
        {
            Format = GraphicFormats.Unknown;
            Aspect = PictureAspects.Unknown;
            Status = GraphicStatus.ForSale;

            DisplayInCarousel = false;
            DisplayOnHomePage = false;
            Paper = "Hahnemuhle 350gm Museum Etching Paper";
        }

        public double CalculateMetricSize(double imperialSize)
        {
            return imperialSize / INCHES_TO_CENTIMETERS;
        }
    }

    public enum PictureAspects
    {
        Unknown,
        Portrait,
        Landscape
    }

     public enum GraphicStatus
    {
        Unknown,
        ForSale,
        UnderOffer,
        Sold,
        Withdrawn
    }

    public enum GraphicFormats
    {
        Unknown,
        Standard, 
        Medium,
        Large,
        Portfolios,
        Complete
    }
    public enum FrameMaterial
    {
        Unknown,
        Glass,
        Perspex
    }
}