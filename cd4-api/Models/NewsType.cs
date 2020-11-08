using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cd4_api.Models
{
    public partial class NewsType
    {
        public NewsType()
        {
            News = new HashSet<News>();
        }
       

        [Key]
        [Column("id")]
        [StringLength(10)]
        public string Id { get; set; }
        [Required]
        [Column("newstypeName")]
        [StringLength(200)]
        public string NewstypeName { get; set; }

        [InverseProperty("Newtype")]
        public virtual ICollection<News> News { get; set; }
    }
}
