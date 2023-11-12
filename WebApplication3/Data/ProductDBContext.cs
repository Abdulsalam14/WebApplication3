using Microsoft.EntityFrameworkCore;
using WebApplication3.Entities;

namespace WebApplication3.Data
{
    public class ProductDBContext:DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options):base(options)
        {
            
        }
        public DbSet<Category>?Categories { get; set; }
        public DbSet<Product>?Products { get; set; }

    }
}
