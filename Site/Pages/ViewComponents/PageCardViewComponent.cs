using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System.Linq;

namespace Site.Pages.ViewComponents
{
    public class PageCard : ViewComponent
    {
        private readonly ISitemapModelRepository _sitemapContext;
        public PageCard(ISitemapModelRepository sitemapContext) => _sitemapContext = sitemapContext;

        public IViewComponentResult Invoke(uint pageNumber, bool imageIcon)
        {
            SitemapModel page = _sitemapContext.Sitemaps.FirstOrDefault(p => p.PageNumber == pageNumber);

            if (page == null)
            {
                page = _sitemapContext.Sitemaps.FirstOrDefault(p => p.PageNumber == 0);
            }

            ViewData["ImageIcon"] = imageIcon;

            return View(page);
        }
    }
}