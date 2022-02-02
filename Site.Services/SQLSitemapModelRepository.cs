using Microsoft.EntityFrameworkCore;
using Site.Models;
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

        public SitemapModel GetPage(uint? pageNumber)
        {
            if (_siteContext.SitemapModels.FirstOrDefault(x => x.PageNumber == pageNumber) == null)
            {
                pageNumber = 0;
            }

            return _siteContext.SitemapModels.Include(p => p.ImageModel).FirstOrDefault(x => x.PageNumber == pageNumber);
        }
    }
}