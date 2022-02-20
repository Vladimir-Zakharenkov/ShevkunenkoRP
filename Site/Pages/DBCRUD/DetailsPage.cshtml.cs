using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class DetailsPageModel : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;
        public DetailsPageModel(ISitemapModelRepository sitemapContext)
        {
            _sitemapContext = sitemapContext;
        }

        public uint PageNumber { get; set; }

        public SitemapModel SitemapItem { get; set; }

        public IActionResult OnGet()
        {
            PageNumber = 15;

            SitemapItem = _sitemapContext.GetPageById(SitemapItem.SitemapModelId);

            if (SitemapItem == null)
            {
                return RedirectToPage("ViewPages");
            }

            return Page();
        }
    }
}
