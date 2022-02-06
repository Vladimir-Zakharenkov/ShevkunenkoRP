using Site.Models;
using System;
using System.Collections.Generic;

namespace Site.Services
{
    public interface ISitemapModelRepository
    {
        public IEnumerable<SitemapModel> Sitemaps { get; }

        SitemapModel GetPage(uint? pageNumber);

        SitemapModel GetPageById(Guid sitemapModelId);

        uint GetPageNumber(uint? pageNumber);

        void AddSitemapItem(SitemapModel sitemapItem);

        void DeletePageById(Guid sitemapModelId);
    }
}