using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cd4_api.Models
{
    public partial class CumulativePoints
    {
        [Key]
        [Column("id")]
        [StringLength(10)]
        public string Id { get; set; }
        [Column("addBonusPoints")]
        public int AddBonusPoints { get; set; }
        [Column("totalScore")]
        public int TotalScore { get; set; }
        [Column("changePoint")]
        public int ChangePoint { get; set; }
        [Column("priceId")]
        [StringLength(10)]
        public string PriceId { get; set; }
        [Column("userId")]
        [StringLength(10)]
        public string UserId { get; set; }

        [ForeignKey(nameof(PriceId))]
        [InverseProperty("CumulativePoints")]
        public virtual Price Price { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Dbuser.CumulativePoints))]
        public virtual Dbuser User { get; set; }
    }
}
