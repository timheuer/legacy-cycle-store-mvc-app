using CycleStore.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CycleStore.Web.Data
{
    public class CycleStoreContext : DbContext
    {
        public CycleStoreContext(DbContextOptions<CycleStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductSubcategory> ProductSubcategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductSubcategory>()
                .HasOne(s => s.ProductCategory)
                .WithMany(c => c.ProductSubcategories)
                .HasForeignKey(s => s.ProductCategoryID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductSubcategory)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.ProductSubcategoryID)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
