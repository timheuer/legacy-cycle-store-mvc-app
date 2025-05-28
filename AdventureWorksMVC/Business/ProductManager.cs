using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Business
{
    /// <summary>
    /// Contains methods related to products.
    /// </summary>
    public class ProductManager
    {
        private readonly CycleStoreDbContext _context;

        public ProductManager(CycleStoreDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets the product by name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public async Task<Product?> GetProductByNameAsync(string name)
        {
            return await _context.Products
                .FirstOrDefaultAsync(p => p.Name == name);
        }

        /// <summary>
        /// Get product by category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public IQueryable<Product> GetProductByCategory(ProductSubcategory category)
        {
            return _context.Products
                .Where(p => p.ProductSubcategoryID == category.ProductSubcategoryID);
        }

        /// <summary>
        /// Get product by ProductId
        /// </summary>
        /// <param name="prodId"></param>
        /// <returns></returns>
        public async Task<Product?> GetProductByProductIdAsync(int prodId)
        {
            return await _context.Products
                .FirstOrDefaultAsync(p => p.ProductID == prodId);
        }

        /// <summary>
        /// Get Product's Colors By category
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public async Task<List<string>> GetProductColorsAsync(int categoryId)
        {
            return await _context.Products
                .Where(p => p.Color != null && p.ProductSubcategoryID == categoryId)
                .OrderBy(p => p.Color)
                .Select(p => p.Color!)
                .Distinct()
                .ToListAsync();
        }

        /// <summary>
        /// Get Product's Weights By category
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public async Task<List<decimal?>> GetProductWeightsAsync(int categoryId)
        {
            return await _context.Products
                .Where(p => p.ProductSubcategoryID == categoryId && p.Weight != null)
                .OrderBy(p => p.Weight)
                .Select(p => p.Weight)
                .Distinct()
                .ToListAsync();
        }

        /// <summary>
        /// Get Product's Sizes By category
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public async Task<List<string>> GetProductSizesAsync(int categoryId)
        {
            return await _context.Products
                .Where(p => p.Size != null && p.ProductSubcategoryID == categoryId)
                .OrderBy(p => p.Size)
                .Select(p => p.Size!)
                .Distinct()
                .ToListAsync();
        }
    }
}