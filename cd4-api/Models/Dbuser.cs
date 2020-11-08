using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cd4_api.Models
{
    [Table("DBUser")]
    public partial class Dbuser
    {
        public Dbuser()
        {
            CumulativePoints = new HashSet<CumulativePoints>();
        }

        [Key]
        [Column("id")]
        [StringLength(10)]
        public string Id { get; set; }
        [Required]
        [Column("fullname")]
        [StringLength(100)]
        public string Fullname { get; set; }
        [Required]
        [Column("dateOfBirth")]
        [StringLength(100)]
        public string DateOfBirth { get; set; }
        [Required]
        [Column("userAddress")]
        [StringLength(200)]
        public string UserAddress { get; set; }
        [Required]
        [Column("email")]
        [StringLength(150)]
        public string Email { get; set; }
        [Column("phoneNumber")]
        public int PhoneNumber { get; set; }
        [Required]
        [Column("acountName")]
        [StringLength(150)]
        public string AcountName { get; set; }
        [Required]
        [Column("userPassword")]
        [StringLength(30)]
        public string UserPassword { get; set; }
        [Required]
        [Column("returnPassword")]
        [StringLength(30)]
        public string ReturnPassword { get; set; }
        [Required]
        [Column("userRole")]
        [StringLength(50)]
        public string UserRole { get; set; }
        [Required]
        [Column("active")]
        [StringLength(50)]
        public string Active { get; set; }
        [Required]
        [Column("sale")]
        [StringLength(10)]
        public string Sale { get; set; }

        [InverseProperty("IdNavigation")]
        public virtual BillSale BillSale { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual ImportInvoice ImportInvoice { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<CumulativePoints> CumulativePoints { get; set; }
    }
}
