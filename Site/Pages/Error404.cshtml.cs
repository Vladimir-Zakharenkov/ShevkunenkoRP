using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Services;

namespace Site.Pages
{
    public class Error404Model : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;

        public Error404Model(ISitemapModelRepository sitemapContext)
        {
            _sitemapContext = sitemapContext;
        }

        public uint PageNumber { get; set; }

        public IActionResult OnGet(uint? pageNumber = 4)
        {
            PageNumber = _sitemapContext.GetPage(pageNumber).PageNumber;

            return Page();
        }
    }
}