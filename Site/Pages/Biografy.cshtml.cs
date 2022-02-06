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

        [BindProperty(SupportsGet = true)]
        public uint PageNumber { get; set; }

        public IActionResult OnGet()
        {
            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            return Page();
        }
    }
}
