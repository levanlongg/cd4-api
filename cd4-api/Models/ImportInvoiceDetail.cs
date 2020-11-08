using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cd4_api.Models
{
    public partial class ImportInvoiceDetail
    {
        [Key]
        [Column("id")]
        [StringLength(10)]
        public string Id { get; set; }
        [Column("importInvoidId")]
        [StringLength(10)]
        public string ImportInvoidId { get; set; }
        [Column("productId")]
        [StringLength(10)]
        public string ProductId { get; set; }
        [Column("amount")]
        public int Amount { get; set; }
        [Column("unitPrice")]
        public int UnitPrice { get; set; }

        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(Product.ImportInvoiceDetail))]
        public virtual Product Id1 { get; set; }
        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(ImportInvoice.ImportInvoiceDetail))]
        public virtual ImportInvoice IdNavigation { get; set; }
    }
}
