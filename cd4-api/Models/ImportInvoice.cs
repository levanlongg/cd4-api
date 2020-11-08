using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cd4_api.Models
{
    public partial class ImportInvoice
    {
        [Key]
        [Column("id")]
        [StringLength(10)]
        public string Id { get; set; }
        [Column("dateAdded", TypeName = "datetime")]
        public DateTime DateAdded { get; set; }
        [Column("producerId")]
        [StringLength(10)]
        public string ProducerId { get; set; }
        [Column("personImportId")]
        [StringLength(10)]
        public string PersonImportId { get; set; }
        [Column("totalMoney")]
        public int TotalMoney { get; set; }

        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(Producer.ImportInvoice))]
        public virtual Producer Id1 { get; set; }
        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(Dbuser.ImportInvoice))]
        public virtual Dbuser IdNavigation { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual ImportInvoiceDetail ImportInvoiceDetail { get; set; }
    }
}
