using LakeCreekRanch.Web.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace LakeCreekRanch.Web.Data
{
    public class Lot
    {
        public int LotId { get; set; }

        [Display(Name = "Development Phase ID")]
        public int DevelopmentPhaseID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Display(Name = "Total Acres")]
        public decimal TotalAcres { get; set; }

        [Display(Name = "Sale Status")]
        public SaleStatus SaleStatus { get; set; }

        [Display(Name = "Development Phase")]
        public DevelopmentPhase DevelopmentPhase { get; set; }

        public string FullName
        {
            get {
                return $"{this.DevelopmentPhase.Name}: {this.Name}";
            }
        }
    }
}