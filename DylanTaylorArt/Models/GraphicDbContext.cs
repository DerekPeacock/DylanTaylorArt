using System;
using System.Data.Entity;


namespace DylanTaylorArt.Models
{
    public class GraphicDbContext : DbContext
    {
        public GraphicDbContext() : base("DefaultConnection")
        {
        }
        public DbSet<Graphic> Graphics { get; set; }
    }
}