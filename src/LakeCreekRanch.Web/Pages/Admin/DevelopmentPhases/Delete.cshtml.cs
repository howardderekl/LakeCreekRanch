using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LakeCreekRanch.Web.Data;

namespace LakeCreekRanch.Web.Pages.Admin.DevelopmentPhases
{
    public class DeleteModel : PageModel
    {
        private readonly LakeCreekRanch.Web.Data.ApplicationDbContext _context;

        public DeleteModel(LakeCreekRanch.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DevelopmentPhase DevelopmentPhase { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DevelopmentPhase = await _context.DevelopmentPhase.SingleOrDefaultAsync(m => m.DevelopmentPhaseId == id);

            if (DevelopmentPhase == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DevelopmentPhase = await _context.DevelopmentPhase.FindAsync(id);

            if (DevelopmentPhase != null)
            {
                _context.DevelopmentPhase.Remove(DevelopmentPhase);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
