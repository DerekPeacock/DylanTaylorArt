using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DylanTaylorArt.Models
{
    public class GraphicCollection
    {
        public int GraphicCollectionId { get; set; }

        [Required]
        public string CollectionName { get; set; }

        [Required]
        public string Artist { get; set; }

        public int Year { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Graphic> Graphics { get; set; }
    }

    public enum Artists
    {
        [Display(Name = "Bob Dylan")]
        Bob_Dylan
    }
}