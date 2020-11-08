using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cd4_api.Models
{
    public partial class Product
    {
        [Key]
        [Column("id")]
        [StringLength(10)]
        public string Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [Column("demo")]
        [StringLength(10)]
        public string Demo { get; set; }
        [Column("updateDay", TypeName = "datetime")]
        public DateTime UpdateDay { get; set; }
        [Column("yearOfManufacturer")]
        public int YearOfManufacturer { get; set; }
        [Required]
        [Column("origin")]
        [StringLength(200)]
        public string Origin { get; set; }

        internal static IEnumerable<object> AsAsyncEnumerable()
        {
            throw new NotImplementedException();
        }

        [Required]
        [Column("production")]
        [StringLength(200)]
        public string Production { get; set; }
        [Required]
        [Column("size1")]
        [StringLength(200)]
        public string Size1 { get; set; }
        [Required]
        [Column("size2")]
        [StringLength(200)]
        public string Size2 { get; set; }
        [Required]
        [Column("material")]
        [StringLength(250)]
        public string Material { get; set; }
        [Required]
        [Column("tutorial")]
        [StringLength(500)]
        public string Tutorial { get; set; }
        [Required]
        [Column("pattern")]
        [StringLength(250)]
        public string Pattern { get; set; }
        [Required]
        [Column("productInclude")]
        [StringLength(300)]
        public string ProductInclude { get; set; }
        [Required]
        [Column("note")]
        [StringLength(200)]
        public string Note { get; set; }
        [Required]
        [Column("numberOfItems")]
        [StringLength(100)]
        public string NumberOfItems { get; set; }
        [Required]
        [Column("capacity")]
        [StringLength(50)]
        public string Capacity { get; set; }
        [Required]
        [Column("productLine")]
        [StringLength(200)]
        public string ProductLine { get; set; }
        [Column("shipmentNumber")]
        public int ShipmentNumber { get; set; }
        [Required]
        [Column("generalIntroduction", TypeName = "ntext")]
        public string GeneralIntroduction { get; set; }
        [Required]
        [Column("detailedIntroduction")]
        public string DetailedIntroduction { get; set; }
        [Column("productypeId")]
        [StringLength(10)]
        public string ProductypeId { get; set; }
        [Column("amount")]
        public int Amount { get; set; }
        [Required]
        [Column("productStatus")]
        [StringLength(50)]
        public string ProductStatus { get; set; }

        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(ProductType.Product))]
        public virtual ProductType IdNavigation { get; set; }
        [InverseProperty("Id1")]
        public virtual BillSaleDetail BillSaleDetail { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual Discount Discount { get; set; }
        [InverseProperty("Id1")]
        public virtual ImportInvoiceDetail ImportInvoiceDetail { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual Price Price { get; set; }
    }
}
