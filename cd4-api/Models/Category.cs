using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cd4_api.Models
{
    public partial class Category
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("productypeId")]
        [StringLength(10)]
        public string ProductypeId { get; set; }
        [Required]
        [Column("categoryName")]
        [StringLength(200)]
        public string CategoryName { get; set; }

        [ForeignKey(nameof(ProductypeId))]
        [InverseProperty(nameof(ProductType.Category))]
        public virtual ProductType Productype { get; set; }
    }
}
