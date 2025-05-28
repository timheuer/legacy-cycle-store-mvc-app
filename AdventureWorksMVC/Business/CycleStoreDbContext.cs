using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Business
{
    public class CycleStoreDbContext : DbContext
    {
        public CycleStoreDbContext(DbContextOptions<CycleStoreDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductSubcategory> ProductSubcategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Product
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductID);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
                entity.Property(e => e.ProductNumber).IsRequired().HasMaxLength(25);
                entity.Property(e => e.Color).HasMaxLength(15);
                entity.Property(e => e.Size).HasMaxLength(5);
                entity.Property(e => e.SizeUnitMeasureCode).HasMaxLength(3);
                entity.Property(e => e.WeightUnitMeasureCode).HasMaxLength(3);
                entity.Property(e => e.ProductLine).HasMaxLength(2);
                entity.Property(e => e.Class).HasMaxLength(2);
                entity.Property(e => e.Style).HasMaxLength(2);
                entity.Property(e => e.StandardCost).HasColumnType("money");
                entity.Property(e => e.ListPrice).HasColumnType("money");
                entity.Property(e => e.Weight).HasColumnType("decimal(8,2)");

                entity.HasOne(d => d.ProductSubcategory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductSubcategoryID);
            });

            // Configure ProductCategory
            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasKey(e => e.ProductCategoryID);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
            });

            // Configure ProductSubcategory
            modelBuilder.Entity<ProductSubcategory>(entity =>
            {
                entity.HasKey(e => e.ProductSubcategoryID);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.ProductSubcategories)
                    .HasForeignKey(d => d.ProductCategoryID);
            });
        }
    }
}