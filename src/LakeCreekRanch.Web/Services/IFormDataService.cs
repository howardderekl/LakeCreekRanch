using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LakeCreekRanch.Web.Services
{
    public interface IFormDataService
    {
        List<SelectListItem> GetDevelopmentPhases();

        List<SelectListItem> GetLots();
        
    }
}
