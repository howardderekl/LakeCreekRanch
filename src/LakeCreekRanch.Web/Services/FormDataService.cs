using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using LakeCreekRanch.Web.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LakeCreekRanch.Web.Services
{
    public class FormDataService : IFormDataService
    {

        public FormDataService(ApplicationDbContext context)
        {
            _context = context;
        }

        public ApplicationDbContext _context { get; }

        public List<SelectListItem> GetDevelopmentPhases()
        {
            return _context.DevelopmentPhase
                .OrderBy(d => d.Name)
                .Select(d => new SelectListItem()
                {
                    Text = d.Name,
                    Value = d.DevelopmentPhaseId.ToString()
                })
                .ToList();
        }

        public List<SelectListItem> GetLots()
        {
            return _context.Lot
                .Include(l => l.DevelopmentPhase)
                .OrderBy(l => l.DevelopmentPhase.Name)
                .ThenBy(l => l.Name)
                .ToList()
                .Select(l => new SelectListItem()
                {
                    Text = l.FullName,
                    Value = l.LotId.ToString()
                })
                .ToList();
        }
    }
}
