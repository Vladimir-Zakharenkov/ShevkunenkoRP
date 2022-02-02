using Site.Models;
using System.Collections.Generic;

namespace Site.Services
{
    public interface ISitemapModelRepository
    {
        public IEnumerable<SitemapModel> Sitemaps { get; }

        void AddSitemapItem(SitemapModel sitemapItem);

        SitemapModel GetPage(uint? pageNumber);
    }
}