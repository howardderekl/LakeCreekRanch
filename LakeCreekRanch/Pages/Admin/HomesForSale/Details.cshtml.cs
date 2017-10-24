using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LakeCreekRanch.Data;

namespace LakeCreekRanch.Pages.Admin.HomesForSale
{
    public class DetailsModel : PageModel
    {
        private readonly LakeCreekRanch.Data.ApplicationDbContext _context;

        public DetailsModel(LakeCreekRanch.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public HomeForSale HomeForSale { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HomeForSale = await _context.HomeForSale
                .Include(h => h.Lot).SingleOrDefaultAsync(m => m.HomeForSaleId == id);

            if (HomeForSale == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
