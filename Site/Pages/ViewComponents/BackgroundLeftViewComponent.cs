﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Site.Models;
using Site.Services;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Pages.ViewComponents
{
    public class BackgroundLeft : ViewComponent
    {
        private readonly ISitemapModelRepository _sitemapContext;
        public BackgroundLeft(ISitemapModelRepository sitemapContext) => _sitemapContext = sitemapContext;

        public async Task<IViewComponentResult> InvokeAsync(uint? pageNumber)
        {
            if (pageNumber == null || await _sitemapContext.Sitemaps.FirstAsync(x => x.PageNumber == pageNumber) == null)
            {
                pageNumber = 0;
            }

            SitemapModel sitemapModel = await _sitemapContext.GetPageAsync(pageNumber);

            return View(sitemapModel);
        }
    }
}