using LakeCreekRanch.Web.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LakeCreekRanch.Web.Data
{
    public class HomeForSale
    {
        public int HomeForSaleId { get; set; }

        [Required]
        public string Description { get; set; }
        public string Address { get; set; }

        [Display(Name = "MLS Listing URL")]
        public string MlsUrl { get; set; }

        [Required]
        [Display(Name = "Total Square Feet")]
        public int TotalSquareFeet { get; set; }

        [Display(Name = "Bedroom Count")]
        public int BedroomCount { get; set; }

        [Display(Name = "Bathroom Count")]
        public decimal BathroomCount { get; set; }

        [Display(Name = "Hide From Website")]
        public bool HideFromWebsite { get; set; }

        [Display(Name = "Completion Date")]
        [DataType(DataType.Date)]
        public DateTime CompletionDate { get; set; }

        [Display(Name = "Sale Status")]
        public SaleStatus SaleStatus { get; set; }

        public int LotId { get; set; }

        public virtual Lot Lot { get; set; }
    }
}
