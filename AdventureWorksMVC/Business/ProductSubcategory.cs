using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Business
{
    public class ProductSubcategory
    {
        public int ProductSubcategoryID { get; set; }
        public int ProductCategoryID { get; set; }
        
        [Required]
        public string Name { get; set; } = string.Empty;
        
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    
        public virtual ProductCategory? ProductCategory { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}