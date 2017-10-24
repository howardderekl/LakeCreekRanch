using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LakeCreekRanch.Web.Data
{
    public class DevelopmentPhase
    {
        public int DevelopmentPhaseId { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "Complete Date")]
        [DataType(DataType.Date)]
        public DateTime CompleteDate { get; set; }

        [Display(Name = "Hide From Website")]
        public bool HideFromWebsite { get; set; } = false;

        public virtual ICollection<Lot> Lots { get; set; }

    }
}
