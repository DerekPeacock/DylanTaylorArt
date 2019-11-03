using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DylanTaylorArt.Models
{
    public class Graphic
    {
        public const double INCHES_TO_CENTIMETERS = 2.54;

        public int GraphicID { get; set; }

        [Required, ForeignKey("Collection")]
        public int CollectionID { get; set; }

        [Range(0, 296), Display(Name ="Copy No")]
        public int CopyNo { get; set; }

        [Required, StringLength(60)]
        public string Title { get; set; }

        [StringLength(500)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [StringLength(100)]
        public string LargeImagePath { get; set; }

        [StringLength(100), Display(Name ="Image Name")]
        public string SmallImagePath { get; set; }

        public GraphicFormats Format { get; set; }

        public Portfolios Portfolio { get; set; }

        [StringLength(60)]
        public string Paper { get; set; }

        public PictureAspects Aspect { get; set; }

        public double ImageWidth { get; set; }

        public double ImageHeight { get; set; }

        public double PaperWidth { get; set; }

        public double PaperHeight { get; set; }

        public GraphicStatus Status { get; set; }

        [Display(Name ="Framed")]
        public FrameMaterial FramedWith { get; set; }

        public bool DisplayOnHomePage { get; set; }

        [DataType(DataType.Currency), Display(Name ="Price (£)")]
        [DisplayFormat(DataFormatString ="{0:C0}")]
         public decimal Price { get; set; }

        [DataType(DataType.Currency), Display(Name ="BDA Price (£)")]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal BDA_Price { get; set; }

        [DataType(DataType.Currency), Display(Name ="Castle Price (£)")]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal CastlePrice { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal CanvasPrice { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal CFA_Price { get; set; }


        public virtual Collection Collection { get; set; }

        public Graphic()
        {
            Format = GraphicFormats.Unknown;
            Aspect = PictureAspects.Unknown;
            Status = GraphicStatus.ForSale;
            FramedWith = FrameMaterial.Glass;

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
        [Display(Name ="For Sale")]
        ForSale,
        [Display(Name = "Under Offer")]
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
        Complete,
        Small
    }

    public enum Portfolios
    {
        None,
        [Display(Name = "Part 1 of 4")]
        Parts_1of4,
        [Display(Name = "Set of 4")]
        Setof_4,
        [Display(Name = "Set of 3")]
        Setof_3,
        [Display(Name = "Part 1 of 3")]
        Parts_1of3
    }

    public enum FrameMaterial
    {
        Unknown,
        None,
        Glass,
        Perspex,
        Wooden_Panel
    }
}