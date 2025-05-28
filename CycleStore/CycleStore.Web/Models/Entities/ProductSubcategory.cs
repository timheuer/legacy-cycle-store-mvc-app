using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CycleStore.Web.Models.Entities
{
    [Table("ProductSubcategory", Schema = "Production")]
    public class ProductSubcategory
    {
        public ProductSubcategory()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int ProductSubcategoryID { get; set; }
        
        [Required]
        public int ProductCategoryID { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        [Required]
        public Guid rowguid { get; set; }
        
        [Required]
        public DateTime ModifiedDate { get; set; }
        
        [ForeignKey("ProductCategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }
        
        public virtual ICollection<Product> Products { get; set; }
    }
}
