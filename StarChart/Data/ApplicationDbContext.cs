using System.Security.Policy;
using Microsoft.EntityFrameworkCore;
using StarChart.Models;

namespace StarChart.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            public DbSet<CelastialObject> CelastialObject { set; get; }
        }
    }
}
