using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Site.Models;
using Site.Services;

namespace Site.Pages.ViewComponents
{
    public class PageCard : ViewComponent
    {
        private readonly ISitemapModelRepository _sitemapContext;
        public PageCard(ISitemapModelRepository sitemapContext) => _sitemapContext = sitemapContext;

        public async Task<IViewComponentResult> InvokeAsync(uint pageNumber, bool imageIcon)
        {
            SitemapModel page = await _sitemapContext.Sitemaps.FirstAsync(p => p.PageNumber == pageNumber);

            if (page == null) page = await _sitemapContext.Sitemaps.FirstAsync(p => p.PageNumber == 0);

            ViewData["ImageIcon"] = imageIcon;

            return View(page);
        }
    }
}