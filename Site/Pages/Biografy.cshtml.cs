using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Services;

namespace Site.Pages
{
    public class BiografyModel : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;

        public BiografyModel(ISitemapModelRepository sitemapContext)
        {
            _sitemapContext = sitemapContext;
        }

        public uint PageNumber { get; set; }

        public IActionResult OnGet(uint? pageNumber = 5)
        {
            PageNumber = _sitemapContext.GetPage(pageNumber).PageNumber;

            return Page();
        }
    }
}
