using Site.Models;
using System.Collections.Generic;

namespace Site.Services
{
    public class SQLImageModelRepository : IImageModelRepository
    {
        private readonly SiteContext _siteContext;

        public SQLImageModelRepository(SiteContext siteContext)
        {
            _siteContext = siteContext;
        }

        public IEnumerable<ImageModel> Images => _siteContext.ImageModels;

        public async void AddImage(ImageModel image)
        {
            _siteContext.ImageModels.Add(image);
            _siteContext.SaveChanges();
        }
    }
}