using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System.Linq;

namespace Site.Pages.ViewComponents
{
    public class BackgroundRight : ViewComponent
    {
        private readonly ISitemapModelRepository _sitemapContext;

        public BackgroundRight(ISitemapModelRepository sitemapContext) => _sitemapContext = sitemapContext;

        public IViewComponentResult Invoke(uint? pageNumber)
        {
            if (pageNumber == null || _sitemapContext.Sitemaps.FirstOrDefault(x => x.PageNumber == pageNumber) == null)
            {
                pageNumber = 0;
            }

            SitemapModel sitemapModel = _sitemapContext.GetPage(pageNumber);

            return View(sitemapModel);
        }
    }
}