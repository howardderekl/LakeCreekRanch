using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LakeCreekRanch.Data;

namespace LakeCreekRanch.Pages.Admin.Lots
{
    public class DetailsModel : PageModel
    {
        private readonly LakeCreekRanch.Data.ApplicationDbContext _context;

        public DetailsModel(LakeCreekRanch.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Lot Lot { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Lot = await _context.Lot
                .Include(l => l.DevelopmentPhase).SingleOrDefaultAsync(m => m.LotId == id);

            if (Lot == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
