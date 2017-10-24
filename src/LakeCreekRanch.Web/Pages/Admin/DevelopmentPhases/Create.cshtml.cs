using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LakeCreekRanch.Web.Data;

namespace LakeCreekRanch.Web.Pages.Admin.DevelopmentPhases
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
            return Page();
        }

        [BindProperty]
        public DevelopmentPhase DevelopmentPhase { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DevelopmentPhase.Add(DevelopmentPhase);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}