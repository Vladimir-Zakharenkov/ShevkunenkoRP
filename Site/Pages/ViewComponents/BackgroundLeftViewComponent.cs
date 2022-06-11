using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Site.Models;
using Site.Services;
using System.Linq;

namespace Site.Pages.ViewComponents
{
    public class BackgroundLeft : ViewComponent
    {
        private readonly SiteContext _siteContext;
        public BackgroundLeft(SiteContext siteContext) => _siteContext = siteContext;

        public IViewComponentResult Invoke(uint? pageNumber)
        {
            if (pageNumber == null || _siteContext.SitemapModels.FirstOrDefault(x => x.PageNumber == pageNumber) == null)
            {
                pageNumber = 0;
            }

            SitemapModel sitemapModel = _siteContext.SitemapModels.Include(p => p.ImageModel).Include(m => m.MovieModel).FirstOrDefault(x => x.PageNumber == pageNumber);

            return View(sitemapModel);
        }
    }
}