using LakeCreekRanch.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace LakeCreekRanch.Data
{
    public class Lot
    {
        public int LotId { get; set; }

        [Display(Name = "Development Phase")]
        public int DevelopmentPhaseID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Display(Name = "Total Acres")]
        public decimal TotalAcres { get; set; }

        public SaleStatus SaleStatus { get; set; }

        public virtual DevelopmentPhase DevelopmentPhase { get; set; }
    }
}