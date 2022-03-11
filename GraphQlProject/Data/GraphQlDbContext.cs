using GraphQlProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQlProject.Data
{
    public class GraphQlDbContext : DbContext
    {
        public GraphQlDbContext(DbContextOptions<GraphQlDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
