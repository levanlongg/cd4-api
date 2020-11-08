using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cd4_api.Models
{
    public partial class ProductType
    {
        public ProductType()
        {
            Category = new HashSet<Category>();
        }

        [Key]
        [Column("id")]
        [StringLength(10)]
        public string Id { get; set; }
        [Required]
        [Column("productypeName")]
        [StringLength(150)]
        public string ProductypeName { get; set; }
        [Required]
        [Column("characteristics")]
        [StringLength(500)]
        public string Characteristics { get; set; }

        [InverseProperty("IdNavigation")]
        public virtual Product Product { get; set; }
        [InverseProperty("Productype")]
        public virtual ICollection<Category> Category { get; set; }
    }
}
