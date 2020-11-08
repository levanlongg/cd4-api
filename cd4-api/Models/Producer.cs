using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cd4_api.Models
{
    public partial class Producer
    {
        [Key]
        [Column("id")]
        [StringLength(10)]
        public string Id { get; set; }
        [Required]
        [Column("logo")]
        [StringLength(100)]
        public string Logo { get; set; }
        [Required]
        [Column("producerName")]
        [StringLength(150)]
        public string ProducerName { get; set; }
        [Required]
        [Column("producerAddress")]
        [StringLength(200)]
        public string ProducerAddress { get; set; }
        [Required]
        [Column("email")]
        [StringLength(200)]
        public string Email { get; set; }
        [Column("phoneNumber")]
        public int PhoneNumber { get; set; }

        [InverseProperty("Id1")]
        public virtual ImportInvoice ImportInvoice { get; set; }
    }
}
