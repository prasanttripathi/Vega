using Microsoft.EntityFrameworkCore;
using repository.Models;

namespace repository.Persistence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options) : base (options)
        {
            
        }

        public DbSet<Make> Makes { get; set; }
    }
}