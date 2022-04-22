using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
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
            SitemapModel page = await _sitemapContext.Sitemaps.AsQueryable().FirstOrDefaultAsync(p => p.PageNumber == pageNumber);

            if (page == null)
            {
                page = await _sitemapContext.Sitemaps.AsQueryable().FirstOrDefaultAsync(p => p.PageNumber == 0);
            }

            ViewData["ImageIcon"] = imageIcon;

            return await Task.Run(() => View(page));
        }
    }
}