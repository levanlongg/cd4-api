using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cd4_api.Models
{
    public partial class Price
    {
        public Price()
        {
            CumulativePoints = new HashSet<CumulativePoints>();
        }

        [Key]
        [Column("id")]
        [StringLength(10)]
        public string Id { get; set; }
        [Column("productId")]
        [StringLength(10)]
        public string ProductId { get; set; }
        [Column("dateAdded", TypeName = "datetime")]
        public DateTime DateAdded { get; set; }
        [Column("price")]
        public int Price1 { get; set; }
        [Column("startDay", TypeName = "datetime")]
        public DateTime StartDay { get; set; }
        [Column("endDay", TypeName = "datetime")]
        public DateTime EndDay { get; set; }

        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(Product.Price))]
        public virtual Product IdNavigation { get; set; }
        [InverseProperty("Price")]
        public virtual ICollection<CumulativePoints> CumulativePoints { get; set; }
    }
}
