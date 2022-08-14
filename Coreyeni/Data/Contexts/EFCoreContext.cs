using Coreyeni.Data.Config;
using Coreyeni.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Coreyeni.Data.Contexts
{
    public class EFCoreContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SalesHistory>SalesHistories { get; set; }
        public EFCoreContext(DbContextOptions<EFCoreContext>options):base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new CustomerConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
