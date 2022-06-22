using Microsoft.EntityFrameworkCore;
using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Services
{
    public class SQLSitemapModelRepository : ISitemapModelRepository
    {
        private readonly SiteContext _siteContext;
        public SQLSitemapModelRepository(SiteContext siteContext) => _siteContext = siteContext;

        public IAsyncEnumerable<SitemapModel> Sitemaps => _siteContext.SitemapModels.Include(p => p.ImageModel).Include(m => m.MovieModel).AsAsyncEnumerable();

        public async Task AddSitemapItemAsync(SitemapModel sitemapItem)
        {
            await _siteContext.SitemapModels.AddAsync(sitemapItem);
            await _siteContext.SaveChangesAsync();
        }

        public async Task UpdatePageAsync(SitemapModel sitemapItem)
        {
            SitemapModel page = await _siteContext.SitemapModels.FindAsync(sitemapItem.SitemapModelId);

            page.PageNumber = sitemapItem.PageNumber;
            page.Loc = sitemapItem.Loc;
            page.Lastmod = sitemapItem.Lastmod;
            page.Changefreq = sitemapItem.Changefreq;
            page.Priority = sitemapItem.Priority;
            page.LeftBackground = sitemapItem.LeftBackground;
            page.RightBackground = sitemapItem.RightBackground;
            page.Title = sitemapItem.Title;
            page.Description = sitemapItem.Description;
            page.KeyWords = sitemapItem.KeyWords;
            page.CardText = sitemapItem.CardText;
            page.MoviePage = sitemapItem.MoviePage;
            page.ImageModelImageId = sitemapItem.ImageModelImageId;
            page.MovieModelMovieId = sitemapItem.MovieModelMovieId;

            //var entry = _siteContext.SitemapModels.First(e => e.SitemapModelId == pageToUpdate.SitemapModelId);
            //_siteContext.Entry(entry).CurrentValues.SetValues(pageToUpdate);

            await _siteContext.SaveChangesAsync();
        }

        public async Task DeletePageByIdAsync(Guid sitemapModelId)
        {
            var sitemapPageToDelete = await _siteContext.SitemapModels.FindAsync(sitemapModelId);

            _siteContext.SitemapModels.Remove(sitemapPageToDelete);
            await _siteContext.SaveChangesAsync();
        }

        public async Task<SitemapModel> GetPageAsync(uint? pageNumber)
        {
            if (pageNumber == null || await _siteContext.SitemapModels.FirstAsync(x => x.PageNumber == pageNumber) == null)
            {
                pageNumber = 0;
            }

            return await _siteContext.SitemapModels.Include(p => p.ImageModel).Include(m => m.MovieModel).FirstAsync(x => x.PageNumber == pageNumber);
        }

        public async Task<SitemapModel> GetPageByIdAsync(Guid? sitemapModelId)
        {
            return await _siteContext.SitemapModels.Include(i => i.ImageModel).Include(m => m.MovieModel).FirstAsync(x => x.SitemapModelId == sitemapModelId);
        }

        public async Task<uint> GetPageNumberAsync(uint? pageNumber)
        {
            if (pageNumber == null || await _siteContext.SitemapModels.FirstAsync(x => x.PageNumber == pageNumber) == null)
            {
                pageNumber = 0;
            }

            return _siteContext.SitemapModels.Include(i => i.ImageModel).Include(m => m.MovieModel).FirstAsync(x => x.PageNumber == pageNumber).Result.PageNumber;
        }
    }
}