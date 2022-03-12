using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;

namespace Site.Pages.DBCRUD
{
    [Authorize]
    [BindProperties(SupportsGet = true)]
    public class DeletePageModel : PageModel
    {
        private readonly ISitemapModelRepository _sitemapContext;
        public DeletePageModel(ISitemapModelRepository sitemapContext) => _sitemapContext = sitemapContext;

        public uint PageNumber { get; set; }

        public SitemapModel SitemapItem { get; set; }

        public IActionResult OnGet()
        {
            PageNumber = 14;

            SitemapItem = _sitemapContext.GetPageById(SitemapItem.SitemapModelId);

            if (SitemapItem == null)
            {
                return RedirectToPage("Page-List");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            PageNumber = 14;

            _sitemapContext.DeletePageById(SitemapItem.SitemapModelId);

            return RedirectToPage("Page-List");
        }
    }
}