using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System.Collections.Generic;
using System.Linq;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    public class ViewPagesModel : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;
        public ViewPagesModel(ISitemapModelRepository sitemapContext)
        {
            _sitemapContext = sitemapContext;
        }

        public uint PageNumber { get; set; }

        public IEnumerable<SitemapModel> AllPages { get; set; }

        public void OnGet()
        {
            PageNumber = 12;

            AllPages = _sitemapContext.Sitemaps.ToArray();
        }
    }
}