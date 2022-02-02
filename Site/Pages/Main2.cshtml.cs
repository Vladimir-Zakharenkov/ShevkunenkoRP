using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Services;

namespace Site.Pages
{
    public class Main2Model : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;

        public Main2Model(ISitemapModelRepository sitemapContext)
        {
            _sitemapContext = sitemapContext;
        }

        public uint PageNumber { get; set; }

        public IActionResult OnGet(uint? pageNumber = 2)
        {
            PageNumber = _sitemapContext.GetPage(pageNumber).PageNumber;

            return Page();
        }
    }
}