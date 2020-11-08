using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cd4_api.Models
{
    public partial class BillSale
    {
        [Key]
        [Column("id")]
        [StringLength(10)]
        public string Id { get; set; }
        [Column("dateSale", TypeName = "datetime")]
        public DateTime DateSale { get; set; }
        [Column("personImportId")]
        [StringLength(10)]
        public string PersonImportId { get; set; }
        [Column("totalMoney")]
        public int TotalMoney { get; set; }

        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(Dbuser.BillSale))]
        public virtual Dbuser IdNavigation { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual BillSaleDetail BillSaleDetail { get; set; }
    }
}
