using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Site.Models;
using Site.Services;

namespace Site.Pages.ViewComponents
{
    public class Head : ViewComponent
    {
        private readonly ISitemapModelRepository _sitemapContext;
        public Head(ISitemapModelRepository pageContext) => _sitemapContext = pageContext;

        public async Task<IViewComponentResult> InvokeAsync(uint? pageNumber)
        {
            if (await _sitemapContext.GetPageAsync(pageNumber) == null) pageNumber = 0;

            SitemapModel sitemapModel = await _sitemapContext.GetPageAsync(pageNumber);

            return View(sitemapModel);
        }
    }
}