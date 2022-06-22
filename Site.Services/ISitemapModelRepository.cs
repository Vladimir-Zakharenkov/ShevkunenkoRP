using Site.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Site.Services
{
    public interface ISitemapModelRepository
    {
        public IAsyncEnumerable<SitemapModel> Sitemaps { get; }

        Task<SitemapModel> GetPageAsync(uint? pageNumber);

        Task<SitemapModel> GetPageByIdAsync(Guid? sitemapModelId);

        Task<uint> GetPageNumberAsync(uint? pageNumber);

        Task AddSitemapItemAsync(SitemapModel sitemapItem);

        Task UpdatePageAsync(SitemapModel sitemapItem);

        Task DeletePageByIdAsync(Guid sitemapModelId);
    }
}