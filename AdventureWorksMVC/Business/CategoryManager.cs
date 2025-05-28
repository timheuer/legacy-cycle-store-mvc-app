using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Business
{
    /// <summary>
    /// Contains methods related to categories.
    /// </summary>
    public class CategoryManager
    {
        private readonly CycleStoreDbContext _context;

        public CategoryManager(CycleStoreDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets the main categories.
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProductCategory>> GetMainCategoriesAsync()
        {
            return await _context.ProductCategories.ToListAsync();
        }

        /// <summary>
        /// Gets the category by name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public async Task<ProductCategory?> GetCategoryByNameAsync(string name)
        {
            return await _context.ProductCategories
                .FirstOrDefaultAsync(cat => cat.Name == name);
        }

        /// <summary>
        /// Gets the product subcategory by name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public async Task<ProductSubcategory?> GetProductSubcategoryByNameAsync(string name)
        {
            return await _context.ProductSubcategories
                .FirstOrDefaultAsync(cat => cat.Name == name);
        }
    }
}