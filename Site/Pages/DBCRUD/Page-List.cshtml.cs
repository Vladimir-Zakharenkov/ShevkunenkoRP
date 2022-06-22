using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    public class ViewPagesModel : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;
        public ViewPagesModel(ISitemapModelRepository sitemapContext) => _sitemapContext = sitemapContext;

        public uint PageNumber { get; set; }

        public IList<SitemapModel> AllPages { get; set; }

        public async Task OnGetAsync()
        {
            PageNumber = 12;

            AllPages = await _sitemapContext.Sitemaps.ToArrayAsync();
        }
    }
}