using System.Security.Policy;
using Microsoft.EntityFrameworkCore;
using StarChart.Models;

namespace StarChart.Data
{
    public class ApplicationDbContext : DbContext
    { 
        public DbSet<CelestialObject> CelestialObjects { set; get; }
        public ApplicationDbContext(DbContextOptions options, DbSet<CelestialObject> celestialObjects) : base(options)
        {
        }

        public ApplicationDbContext(DbContextOptions optionsBuilderOptions)
        {
        }
    }
}
