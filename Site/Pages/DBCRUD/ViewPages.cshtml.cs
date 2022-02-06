using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System.Collections.Generic;
using System.Linq;

namespace Site.Pages.DBCRUD
{
    [BindProperties(SupportsGet = true)]
    public class ViewPagesModel : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;

        public ViewPagesModel(ISitemapModelRepository sitemapContext)
        {
            _sitemapContext = sitemapContext;
        }

        public uint PageNumber { get; set; }

        public IEnumerable<SitemapModel> AllPages { get; set; }

        public IActionResult OnGet()
        {
            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            AllPages = _sitemapContext.Sitemaps.ToArray();

            return Page();
        }
    }
}