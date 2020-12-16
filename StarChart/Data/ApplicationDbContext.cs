using System.Security.Policy;
using Microsoft.EntityFrameworkCore;
using StarChart.Models;

namespace StarChart.Data
{
    public class ApplicationDbContext : DbContext
    { 
        public DbSet<CelestialObjects> CelestialObjects { set; get; }
        public ApplicationDbContext(DbContextOptions options, DbSet<CelestialObjects> celestialObjects) : base(options)
        {
        }

        public ApplicationDbContext(DbContextOptions optionsBuilderOptions)
        {
            throw new System.NotImplementedException();
        }
    }
}
