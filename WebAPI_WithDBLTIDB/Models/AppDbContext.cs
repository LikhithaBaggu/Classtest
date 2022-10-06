using Microsoft.EntityFrameworkCore;

namespace WebAPI_WithDBLTIDB.Models
{
    public class AppDbContext:DbContext
    { 
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategory> CatwiseProducts { get; set; }

    }
}
