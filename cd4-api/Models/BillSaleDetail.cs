using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cd4_api.Models
{
    public partial class BillSaleDetail
    {
        [Key]
        [Column("id")]
        [StringLength(10)]
        public string Id { get; set; }
        [Column("billSaleId")]
        [StringLength(10)]
        public string BillSaleId { get; set; }
        [Column("productId")]
        [StringLength(10)]
        public string ProductId { get; set; }
        [Column("amount")]
        public int Amount { get; set; }
        [Column("unitPrice")]
        public int UnitPrice { get; set; }

        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(Product.BillSaleDetail))]
        public virtual Product Id1 { get; set; }
        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(BillSale.BillSaleDetail))]
        public virtual BillSale IdNavigation { get; set; }
    }
}
