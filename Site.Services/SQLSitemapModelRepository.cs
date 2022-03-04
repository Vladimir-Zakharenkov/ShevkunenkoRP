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

        public SQLSitemapModelRepository(SiteContext siteContext)
        {
            _siteContext = siteContext;
        }

        public IEnumerable<SitemapModel> Sitemaps => _siteContext.SitemapModels.Include(p => p.ImageModel);

        public void AddSitemapItem(SitemapModel sitemapItem)
        {
            _siteContext.SitemapModels.Add(sitemapItem);
            _siteContext.SaveChanges();
        }

        public void UpdatePage(SitemapModel pageToUpdate)
        {
            SitemapModel page = _siteContext.SitemapModels.Find(pageToUpdate.SitemapModelId);

            page.PageNumber = pageToUpdate.PageNumber;
            page.Loc = pageToUpdate.Loc;
            page.Lastmod = pageToUpdate.Lastmod;
            page.Changefreq = pageToUpdate.Changefreq;
            page.Priority = pageToUpdate.Priority;
            page.LeftBackground = pageToUpdate.LeftBackground;
            page.RightBackground = pageToUpdate.RightBackground;
            page.Title = pageToUpdate.Title;
            page.Description = pageToUpdate.Description;
            page.KeyWords = pageToUpdate.KeyWords;
            page.ImageModelImageId = pageToUpdate.ImageModelImageId;

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

            return _siteContext.SitemapModels.Include(p => p.ImageModel).FirstOrDefault(x => x.PageNumber == pageNumber);
        }

        public SitemapModel GetPageById(Guid? sitemapModelId)
        {
            return _siteContext.SitemapModels.Include(i => i.ImageModel).FirstOrDefault(x => x.SitemapModelId == sitemapModelId);
        }

        public uint GetPageNumber(uint? pageNumber)
        {
            if (pageNumber == null || _siteContext.SitemapModels.FirstOrDefault(x => x.PageNumber == pageNumber) == null)
            {
                pageNumber = 0;
            }

            return _siteContext.SitemapModels.FirstOrDefault(x => x.PageNumber == pageNumber).PageNumber;
        }
    }
}