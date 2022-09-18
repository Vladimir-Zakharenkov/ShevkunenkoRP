using Microsoft.AspNetCore.Mvc;
using Site.Models;
using Site.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Pages.ViewComponents
{
    public class PageLinksBlock : ViewComponent
    {
        private readonly ISitemapModelRepository _sitemapContext;
        public PageLinksBlock(ISitemapModelRepository sitemapContext) => _sitemapContext = sitemapContext;

        public async Task<IViewComponentResult> InvokeAsync(string blockHeader, uint[] pageLinks, bool imageIcon, bool linkSize)
        {
            List<SitemapModel> pageList = new();

            foreach (var item in pageLinks)
            {
                SitemapModel page = await _sitemapContext.Sitemaps.FirstAsync(p => p.PageNumber == item);

                pageList.Add(page);
            }

            ViewData["BlockHeader"] = blockHeader;
            ViewData["ImageIcon"] = imageIcon;
            ViewData["LinkSize"] = linkSize;

            return View(pageList);
        }
    }
}