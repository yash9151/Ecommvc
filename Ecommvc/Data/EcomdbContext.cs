using Ecommvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommvc.Data
{
    public class EcomdbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public EcomdbContext():base()
        {

        }
        public EcomdbContext(DbContextOptions<EcomdbContext> options):base(options)
        {

        }
    }
}
