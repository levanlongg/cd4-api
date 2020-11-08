using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cd4_api.Models
{
    [Table("DBImage")]
    public partial class Dbimage
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("imageName")]
        [StringLength(200)]
        public string ImageName { get; set; }
        [Required]
        [Column("image")]
        [StringLength(200)]
        public string Image { get; set; }
    }
}
