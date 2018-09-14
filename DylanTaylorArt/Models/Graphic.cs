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

        [DataType(DataType.Date)]
        public DateTime DateReleased { get; set; }

        [StringLength(60)]
        public string Paper { get; set; }

        public PictureAspects Aspect { get; set; }

        public Size ImageSize { get; set; }

        public Size FrameSize { get; set; }

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
        }

        public Size CalculateMetricSize(Size imperialSize)
        {
            Size metricSize;

            metricSize.height = imperialSize.height / INCHES_TO_CENTIMETERS;
            metricSize.width = imperialSize.width / INCHES_TO_CENTIMETERS;

            return metricSize;
        }
    }

    public enum PictureAspects
    {
        Unknown,
        Portrait,
        Landscape
    }

    public struct Size
    {
        public double width;
        public double height;
    }

    public enum GraphicStatus
    {
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