using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System.Linq;

namespace Site.Pages.DBCRUD
{
    public class AddSitemapItemModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly ISitemapModelRepository _pageContext;
        private readonly ISitemapModelRepository _sitemapContext;

        public AddSitemapItemModel(ISitemapModelRepository pageContext, ISitemapModelRepository sitemapContext)
        {
            _pageContext = pageContext;
            _sitemapContext = sitemapContext;
        }

        public uint PageNumber { get; set; }
        public string LeftBackground { get; set; }
        public string RightBackground { get; set; }

        [BindProperty]
        public SitemapModel SitemapItem { get; set; }

        public IActionResult OnGet(uint? pageNumber)
        {
            PageNumber = _pageContext.GetPage(pageNumber).PageNumber;

            LeftBackground = _pageContext.GetPage(pageNumber).LeftBackground;

            RightBackground = _pageContext.GetPage(pageNumber).RightBackground;

            return Page();
        }

        public IActionResult OnPost()
        {
            if (_sitemapContext.Sitemaps.FirstOrDefault(x => x.PageNumber == 0) == null)
            {
                SitemapItem.PageNumber = 0;
            }
            else
            {
                SitemapItem.PageNumber = _sitemapContext.Sitemaps.Max(y => y.PageNumber) + 1;
            }

            if (_sitemapContext.Sitemaps.FirstOrDefault(x => x.Loc == SitemapItem.Loc) != null)
            {
                ModelState.AddModelError("SitemapItem.Loc", "Такая страница уже существует");

                return Page();
            }

            if (ModelState.IsValid)
            {
                _sitemapContext.AddSitemapItem(SitemapItem);

                return RedirectToPage("/Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
