﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LakeCreekRanch.Web.Data;

namespace LakeCreekRanch.Web.Pages.Admin.Lots
{
    public class EditModel : PageModel
    {
        private readonly LakeCreekRanch.Web.Data.ApplicationDbContext _context;

        public EditModel(LakeCreekRanch.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Lot).State = EntityState.Modified;

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
