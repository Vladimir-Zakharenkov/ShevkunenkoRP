using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Services;

namespace Site.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;

        public IndexModel(ISitemapModelRepository sitemapContext)
        {
            _sitemapContext = sitemapContext;
        }

        public uint PageNumber { get; set; }

        public IActionResult OnGet(uint? pageNumber = 1)
        {
            PageNumber = _sitemapContext.GetPage(pageNumber).PageNumber;

            return Page();
        }
    }
}