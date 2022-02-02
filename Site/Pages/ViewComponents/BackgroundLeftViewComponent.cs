using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System.Linq;

namespace Site.Pages.ViewComponents
{
    public class BackgroundLeft : ViewComponent
    {
        private readonly ISitemapModelRepository _sitemapContext;

        public BackgroundLeft(ISitemapModelRepository sitemapContext)
        {
            _sitemapContext = sitemapContext;
        }

        public IViewComponentResult Invoke(uint? pageNumber)
        {
            if (_sitemapContext.Sitemaps.FirstOrDefault(x => x.PageNumber == pageNumber) == null)
            {
                pageNumber = 0;
            }

            SitemapModel sitemapModel = _sitemapContext.GetPage(pageNumber);

            return View(sitemapModel);
        }
    }
}
