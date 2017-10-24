using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LakeCreekRanch.Web.Pages.Admin
{
    public static class AdminNavPages
    {
        public static string Index => "Admin\\Index";
        public static string DevelopmentPhases => "Admin\\DevelopmentPhases\\Index";
        public static string Lots => "Admin\\Lots\\Index";
        public static string HomesForSale => "Admin\\HomesForSale\\Index";

        public static string IndexNavClass(ViewContext viewContext) => PageNavClass(viewContext, Index);
        public static string DevelopmentPhasesNavClass(ViewContext viewContext) => PageNavClass(viewContext, DevelopmentPhases);
        public static string LotsNavClass(ViewContext viewContext) => PageNavClass(viewContext, Lots);
        public static string HomesForSaleNavClass(ViewContext viewContext) => PageNavClass(viewContext, HomesForSale);

        public static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string
                ?? System.IO.Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
        }
    }
}
