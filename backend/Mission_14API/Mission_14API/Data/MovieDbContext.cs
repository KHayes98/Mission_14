using Microsoft.EntityFrameworkCore;
using Mission_14API.Models;

namespace Mission_14API.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }

        public DbSet<Movies> Movies { get; set; }
    }
}
