using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Business
{
    public class ProductCategory
    {
        public ProductCategory()
        {
            ProductSubcategories = new HashSet<ProductSubcategory>();
        }
    
        public int ProductCategoryID { get; set; }
        
        [Required]
        public string Name { get; set; } = string.Empty;
        
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ProductSubcategory> ProductSubcategories { get; set; }
    }
}