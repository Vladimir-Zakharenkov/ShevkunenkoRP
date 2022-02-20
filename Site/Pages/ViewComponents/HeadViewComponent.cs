using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;

namespace Site.Pages.ViewComponents
{
    public class Head : ViewComponent
    {
        private readonly ISitemapModelRepository _sitemapContext;
        public Head(ISitemapModelRepository pageContext)
        {
            _sitemapContext = pageContext;
        }

        public IViewComponentResult Invoke(uint? pageNumber)
        {
            if (_sitemapContext.GetPage(pageNumber) == null)
            {
                pageNumber = 0;
            }

            SitemapModel sitemapModel = _sitemapContext.GetPage(pageNumber);

            return View(sitemapModel);
        }
    }
}