using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Services;

namespace Site.Pages.DBCRUD
{
    [BindProperties(SupportsGet = true)]
    public class IndexModel : PageModel
    {

        private readonly ISitemapModelRepository _sitemapContext;

        public IndexModel(ISitemapModelRepository sitemapContext)
        {
            _sitemapContext = sitemapContext;
        }

        public uint PageNumber { get; set; }


        public IActionResult OnGet()
        {
            PageNumber = _sitemapContext.GetPageNumber(PageNumber);

            return Page();
        }
    }
}
