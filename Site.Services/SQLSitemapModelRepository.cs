using Microsoft.EntityFrameworkCore;
using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Site.Services
{
    public class SQLSitemapModelRepository : ISitemapModelRepository
    {
        private readonly SiteContext _siteContext;
        public SQLSitemapModelRepository(SiteContext siteContext) => _siteContext = siteContext;

        public IEnumerable<SitemapModel> Sitemaps => _siteContext.SitemapModels.Include(p => p.ImageModel).Include(m => m.MovieModel);

        public void AddSitemapItem(SitemapModel sitemapItem)
        {
            _siteContext.SitemapModels.Add(sitemapItem);
            _siteContext.SaveChanges();
        }

        public void UpdatePage(SitemapModel sitemapItem)
        {
            SitemapModel page = _siteContext.SitemapModels.Find(sitemapItem.SitemapModelId);

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

            _siteContext.SaveChanges();
        }

        public void DeletePageById(Guid sitemapModelId)
        {
            var sitemapPageToDelete = _siteContext.SitemapModels.Find(sitemapModelId);

            _siteContext.SitemapModels.Remove(sitemapPageToDelete);
            _siteContext.SaveChanges();
        }

        public SitemapModel GetPage(uint? pageNumber)
        {
            if (pageNumber == null || _siteContext.SitemapModels.FirstOrDefault(x => x.PageNumber == pageNumber) == null)
            {
                pageNumber = 0;
            }

            return _siteContext.SitemapModels.Include(p => p.ImageModel).Include(m => m.MovieModel).FirstOrDefault(x => x.PageNumber == pageNumber);
        }

        public SitemapModel GetPageById(Guid? sitemapModelId)
        {
            return _siteContext.SitemapModels.Include(i => i.ImageModel).Include(m => m.MovieModel).FirstOrDefault(x => x.SitemapModelId == sitemapModelId);
        }

        public uint GetPageNumber(uint? pageNumber)
        {
            if (pageNumber == null || _siteContext.SitemapModels.FirstOrDefault(x => x.PageNumber == pageNumber) == null)
            {
                pageNumber = 0;
            }

            return _siteContext.SitemapModels.Include(i => i.ImageModel).Include(m => m.MovieModel).FirstOrDefault(x => x.PageNumber == pageNumber).PageNumber;
        }
    }
}