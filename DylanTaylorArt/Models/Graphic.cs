using System;
using System.ComponentModel.DataAnnotations;


namespace DylanTaylorArt.Models
{
    public class Graphic
    {
        public int GraphicID { get; set; }

        [Required, StringLength(30)]
        public string Collection { get; set; }

        [Required, StringLength(60)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

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
    }

    public enum PictureAspects
    {
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
        Standard, 
        Medium,
        Large
    }
    public enum FrameMaterial
    {
        Glass,
        Perspex
    }
}