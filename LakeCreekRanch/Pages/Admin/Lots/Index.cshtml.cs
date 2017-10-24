﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LakeCreekRanch.Data;

namespace LakeCreekRanch.Pages.Admin.Lots
{
    public class IndexModel : PageModel
    {
        private readonly LakeCreekRanch.Data.ApplicationDbContext _context;

        public IndexModel(LakeCreekRanch.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Lot> Lot { get;set; }

        public async Task OnGetAsync()
        {
            Lot = await _context.Lot
                .Include(l => l.DevelopmentPhase).ToListAsync();
        }
    }
}
