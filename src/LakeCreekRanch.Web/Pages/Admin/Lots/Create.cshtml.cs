using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LakeCreekRanch.Web.Data;

namespace LakeCreekRanch.Web.Pages.Admin.Lots
{
    public class CreateModel : PageModel
    {
        private readonly LakeCreekRanch.Web.Data.ApplicationDbContext _context;

        public CreateModel(LakeCreekRanch.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DevelopmentPhaseID"] = new SelectList(_context.DevelopmentPhase, "DevelopmentPhaseId", "Name");
            return Page();
        }

        [BindProperty]
        public Lot Lot { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Lot.Add(Lot);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}