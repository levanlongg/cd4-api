using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cd4_api.Models
{
    public partial class Discount
    {
        [Key]
        [Column("id")]
        [StringLength(10)]
        public string Id { get; set; }
        [Column("productId")]
        [StringLength(10)]
        public string ProductId { get; set; }
        [Required]
        [Column("percentDiscount")]
        [StringLength(10)]
        public string PercentDiscount { get; set; }
        [Column("reducedPrice")]
        public int ReducedPrice { get; set; }
        [Column("startDay", TypeName = "datetime")]
        public DateTime StartDay { get; set; }
        [Column("endDay", TypeName = "datetime")]
        public DateTime EndDay { get; set; }
        [Column("dateAdded", TypeName = "datetime")]
        public DateTime DateAdded { get; set; }

        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(Product.Discount))]
        public virtual Product IdNavigation { get; set; }
    }
}
