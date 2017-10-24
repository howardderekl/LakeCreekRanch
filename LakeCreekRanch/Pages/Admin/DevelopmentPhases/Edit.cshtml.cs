using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LakeCreekRanch.Data;

namespace LakeCreekRanch.Pages.Admin.DevelopmentPhases
{
    public class EditModel : PageModel
    {
        private readonly LakeCreekRanch.Data.ApplicationDbContext _context;

        public EditModel(LakeCreekRanch.Data.ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DevelopmentPhase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                
            }

            return RedirectToPage("./Index");
        }
    }
}
