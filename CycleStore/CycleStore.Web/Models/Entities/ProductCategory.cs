using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CycleStore.Web.Models.Entities
{
    [Table("ProductCategory", Schema = "Production")]
    public class ProductCategory
    {
        public ProductCategory()
        {
            ProductSubcategories = new HashSet<ProductSubcategory>();
        }

        [Key]
        public int ProductCategoryID { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        [Required]
        public Guid rowguid { get; set; }
        
        [Required]
        public DateTime ModifiedDate { get; set; }
        
        public virtual ICollection<ProductSubcategory> ProductSubcategories { get; set; }
    }
}
