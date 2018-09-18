using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DylanTaylorArt.Models
{
    public class Collection
    {
        [Key]
        public int CollectionID { get; set; }

        [Required, StringLength(60), Display(Name ="Collection")]
        public string CollectionName { get; set; }

        [Required]
        public Artists Artist { get; set; }

        public int Year { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(120), DataType(DataType.MultilineText)]
        public string ImagePath { get; set; }

        public virtual ICollection<Graphic> Graphics { get; set; }
    }

    public enum Artists
    {
        [Display(Name = "Bob Dylan")]
        Bob_Dylan
    }
}