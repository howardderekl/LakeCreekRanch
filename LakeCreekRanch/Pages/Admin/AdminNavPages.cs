using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LakeCreekRanch.Pages.Admin
{
    public static class AdminNavPages
    {
        public static string Index => "Index";
        public static string DevelopmentPhases => "DevelopmentPhases\\Index";

        public static string IndexNavClass(ViewContext viewContext) => PageNavClass(viewContext, Index);
        public static string DevelopmentPhasesNavClass(ViewContext viewContext) => PageNavClass(viewContext, DevelopmentPhases);

        public static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string
                ?? System.IO.Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
        }
    }
}
