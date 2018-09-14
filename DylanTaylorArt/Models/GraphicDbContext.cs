using System;
using System.Data.Entity;


namespace DylanTaylorArt.Models
{
    public class GraphicDbContext : DbContext
    {
        public DbSet<Graphic> Graphics { get; set; }
    }
}