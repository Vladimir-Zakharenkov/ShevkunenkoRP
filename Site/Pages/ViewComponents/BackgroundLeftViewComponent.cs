using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;

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
            SitemapModel sitemapModel = _sitemapContext.GetPage(pageNumber);

            return View(sitemapModel);
        }
    }
}